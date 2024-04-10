/**
* FILE				: Request.cs
* PROJECT			: PROG 2001 - Web Design and Development Assignment 05
* PROGRAMMERS		:
*   Minchul Hwang  ID: 8818858
* FIRST VERSION		: Nov. 26, 2023
* DESCRIPTION		: This class is used when making a request from a client.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOwnWebServer
{
    internal class Request
    {
        public string Method { get; set; }
        public string Path { get; set; }
        public string Version { get; set; }

        /**
        * Constructor : Request
        * DESCRIPTION	    :
        *	    Converts data requested from the client into strings.
        	PARAMETERS		
        *		string        requestLine        String received from client
        *	RETURNS			
        *		None
        */
        public Request(string requestLine)
        {
            ParseRequestLine(requestLine);
        }

        /**
        *	METHOD    : ParseRequestLine()
        *	DESCRIPTION		
        *		Separate the three types of data received from the client and store them in designated variables.
        *	PARAMETERS		
        *		string          requestLine         String received from client
        *	RETURNS			
        *		void	    :	 There are no return values for this method
        */
        private void ParseRequestLine(string requestLine)
        {
            string[] requestParts = requestLine.Split(' ');     // Parse the string based on spaces.

            if (requestParts.Length == 3)
            {
                Method = requestParts[0];
                Path = requestParts[1];
                Version = requestParts[2];
            }
        }
    }
}
