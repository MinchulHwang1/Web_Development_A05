/**
* FILE				: Response.cs
* PROJECT			: PROG 2001 - Web Design and Development Assignment 05
* PROGRAMMERS		:
*   Minchul Hwang  ID: 8818858
* FIRST VERSION		: Nov. 26, 2023
* DESCRIPTION		: It is responsible for returning data requested from the client..
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOwnWebServer
{
    internal class Response
    {
        public int StatusCode { get; set; }
        public string StatusText { get; set; }
        public string ContentType { get; set; }
        public string Content { get; set; }
        public string currentDate {  get; set; }
        public string serverName { get; set; }
        private string logFilePath;
        Logger logger;

        /**
        * Constructor : Response
        * DESCRIPTION	    :
        *	    Instantiates data to respond to the client.
        	PARAMETERS		
        *		int           statusCode            Status code received from server
        *		string        statusText            Status message received from server
        *		string        contentType           Content type received from server
        *		string        content               Contents received from the server
        *	RETURNS			
        *		None
        */
        public Response(int statusCode, string statusText, string contentType, string content)
        {
            StatusCode = statusCode;
            StatusText = statusText;
            ContentType = contentType;
            Content = content;
            currentDate = DateTime.UtcNow.ToString("R");
            serverName = "myOwnWebServer";
            Console.OutputEncoding = Encoding.UTF8;
            logFilePath = "myOwnWebServer.log";
            logger = new Logger(logFilePath);
        }

        /**
        *	METHOD    : ToHttpResponse()
        *	DESCRIPTION		
        *		This method returns reasonable content to be sent to the client.
                Also, the corresponding contents are saved in the log file.
        *	PARAMETERS		
        *		None
        *	RETURNS			
        *		string      responsData         What to output on the client side
        */
        public string ToHttpResponse()
        {
            string responseData = $"HTTP/1.1 {StatusCode} {StatusText}\r\nContent-Type: {ContentType}\r\nContent-Length: {Content.Length}\r\nServer: {serverName}\r\nDate: {currentDate}\r\n\r\n{Content}";
            logger.Log($"[{ContentType}]");
            logger.Log($"[{Content.Length}]");
            logger.Log($"[{serverName}]");
            logger.Log($"[{currentDate}]");
            return responseData;

        }
    }
}
