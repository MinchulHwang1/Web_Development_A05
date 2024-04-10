/**
* FILE				: Logger.cs
* PROJECT			: PROG 2001 - Web Design and Development Assignment 05
* PROGRAMMERS		:
*   Minchul Hwang  ID: 8818858
* FIRST VERSION		: Nov. 26, 2023
* DESCRIPTION		: This class is responsible for creating and writing a log file when a request comes from another program.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myOwnWebServer
{
    internal class Logger
    {
        private string logFilePath;

        /**
        * Constructor : Logger
        * DESCRIPTION	    :
        *	    This class is responsible for creating and writing a log file when a request comes from another program.
        *	    Additionally, the loaded storage path is instantiated as an internal value.
        	PARAMETERS		
        *		string        logFilePath        The Path which the log file will be made and stored
        *	RETURNS			
        *		None
        */
        public Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        /**
        *	METHOD    : Log()
        *	DESCRIPTION		
        *		When this method receives a log creation request from another class, it modifies the file by adding content.
        *	PARAMETERS		
        *		string          message         the message which server want to send
        *	RETURNS			
        *		void	    :	 There are no return values for this method
        */

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}   {message}";

            // Append the log entry to the log file
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
    }
}
