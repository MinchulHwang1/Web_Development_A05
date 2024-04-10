/**
* FILE				: Program.cs
* PROJECT			: PROG 2001 - Web Design and Development Assignment 05
* PROGRAMMERS		:
*   Minchul Hwang  ID: 8818858
* FIRST VERSION		: Nov. 26, 2023
* DESCRIPTION		: This program creates your own server.
                      The server is connected to localWebSite, and the specified port is 5300.
                      The files that this server can read are TEXT, HTML, JPG, and GIF files, and it returns the appropriate value for each.
                      The classes related to this program are Logger, Request, and Response.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;

namespace myOwnWebServer
{
    internal class Program
    {
        public static string logFilePath = "../../myOwnWebServer.log";
        /**
        * CLASS     : Main
        * DESCRIPTION	    :
        *	This function measures the number of command line arguments and extracts the appropriate value. 
        *	The value is the value assigned to webRoot, webIP, and webPort.
        	PARAMETERS		
        *		string[]        args        the command line argument
        *	RETURNS			
        *		void	    :	 There are no return values for this class
        */
        static void Main(string[] args)
        {
            Logger logger = new Logger(logFilePath);
            if (args.Length != 3)
            {
                return;
            }
            else
            {
                logger.Log("[No Properly Arguments]");
            }

            // Get values from Command line arguments
            string webRoot = GetArgumentValue(args[0], "webRoot=");
            string webIP = GetArgumentValue(args[1], "webIP=");
            string webPort = GetArgumentValue(args[2], "webPort=");

            // Put values from command line into tcplistener
            TcpListener tcpListener = new TcpListener(IPAddress.Parse(webIP), int.Parse(webPort));
            try
            {
                tcpListener.Start();        // Open server
            }
            catch (Exception ex)
            {
                logger.Log($"[ERROR : {ex}]");
                return;
            }
            logger.Log("[SERVER STARTED]");

            // Get request from client
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                HandleClient(client, webRoot);
            }
        }

        /**
        *	METHOD    : HandleClient()
        *	DESCRIPTION		
        *		This method is responsible for connecting with the client.
        *       First, it waits until there is a request from the client, and when it receives the request, it sends an appropriate response.
        *	PARAMETERS		
        *		TcpClient       tcpClient       Client class that communicates with the server
        *		string          webRoot         the Root page where client tries to search file
        *	RETURNS			
        *		void	    :	 There are no return values for this method
        */
        static void HandleClient(TcpClient tcpClient, string webRoot)
        {
            Stream stream = tcpClient.GetStream();
            StreamReader reader = new StreamReader(stream);             // An object to read which client request
            StreamWriter writer = new StreamWriter(stream);             // An object that writes content to be sent to the client
            Logger logger = new Logger(logFilePath);


            string requestLine = reader.ReadLine();                     // Store the value which clieent want to search

            Request request = new Request(requestLine);                 // Create a Request Object

            if (request.Method == "GET" && request.Version == "HTTP/1.1")
            {
                string filePath = GetFilePathFromRequest(request.Path, webRoot);        // Variable for finding the data requested by the client

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the file content
                    string content;
                    try
                    {
                        content = File.ReadAllText(filePath);
                    }
                    catch(Exception ex)
                    {
                        logger.Log($"[ERROR : {ex}]");
                        return;
                    }
                    string contentType = GetContentType(filePath);          // Search the Content Type within range(html, text, jpg, and gif)
                    

                    // Create a Response object
                    Response response = new Response(200, "OK", contentType, content);


                    // Send the HTTP response with the file content
                    writer.Write(response.ToHttpResponse());

                }
                else
                {
                    // Handle if the file is error
                    SendErrorResponse(writer, 404);

                }
            }
            logger.Log("[SERVER DISCONNECTED]");
            tcpClient.Close();
        }

        /**
        *	METHOD    : GetFilePathFromRequest()
        *	DESCRIPTION		
        *		This method removes the / from the webRoot and the string of the file the user is looking for.
        *	PARAMETERS		
        *		string          path            the file location where client wants to find
        *		string          webRoot         the Root page where client tries to search file
        *	RETURNS			
        *		string          Path.Combine(webRoot, fileName)         A string containing the location of the file
        */
        static string GetFilePathFromRequest(string path, string webRoot)
        {
            // Remove leading '/' and combine with web root to get the file path
            string fileName = path.TrimStart('/');
            return Path.Combine(webRoot, fileName);
        }

        /**
        *	METHOD    : GetArgumentValue()
        *	DESCRIPTION		
        *		This method is responsible for extracting the values ​​of webRoot, webIP, and webPort from the contents of the command line argument.
        *	PARAMETERS		
        *		string          commandLine             A string on the command line
        *		string          argumentFlag            Flag that identifies data that needs to be extracted
        *	RETURNS			
        *		string          Value extracted from the command line.
        */
        static string GetArgumentValue(string commandLine, string argumentFlag)
        {
            int flagIndex = commandLine.IndexOf(argumentFlag);

            if (flagIndex != -1)
            {
                // Find the value after the flag
                int startIndex = flagIndex + argumentFlag.Length;
                int endIndex = commandLine.IndexOf(' ', startIndex);

                if (endIndex == -1)
                {
                    endIndex = commandLine.Length;
                }

                return commandLine.Substring(startIndex, endIndex - startIndex);
            }

            return null;
        }

        /**
        *	METHOD    : SendErrorResponse()
        *	DESCRIPTION		
        *		Method used when the value the client is looking for does not exist or there is an error.
        *	PARAMETERS		
        *		StreamWriter          writer             An Object sent to client
        *		int                   statusCode         An error number
        *	RETURNS			
        *		void	    :	 There are no return values for this method
        */
        static void SendErrorResponse(StreamWriter writer, int statusCode)
        {
            string statusText = GetStatusText(statusCode);
            Logger logger = new Logger(logFilePath);
            // Send the HTTP response with the error status
            string response = $"HTTP/1.1 {statusCode} {statusText}\r\n\r\n";
            logger.Log($"[{statusCode} {statusText}]");
            writer.Write(response);
        }

        /**
        *	METHOD    : GetStatusText()
        *	DESCRIPTION		
        *		This method returns the appropriate sentence according to the error code.
        *	PARAMETERS		
        *		int                   statusCode         An error number
        *	RETURNS			
        *		string      String matching each error code
        */
        static string GetStatusText(int statusCode)
        {
            switch (statusCode)
            {
                case 100:
                    return "Continue";
                case 200:
                    return "OK";
                case 301:
                    return "Moved Permanently";
                case 404:
                    return "Not Found";
                case 500:
                    return "Server Error";
                default:
                    return "Unknown Status";
            }
        }

        /**
        *	METHOD    : GetContentType()
        *	DESCRIPTION		
        *		This method checks the list of files that the server can read.
        *	PARAMETERS		
        *		string          filePath         String of data requested from the client
        *	RETURNS			
        *		string          Returns the value appropriate for each data
        */
        static string GetContentType(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            switch (extension)
            {
                case ".txt":
                    return "text/plain";
                case ".html":
                case ".htm":
                    return "text/html";
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".gif":
                    return "image/gif";
                default:
                    return "application/octet-stream";
            }
        }
    }
}