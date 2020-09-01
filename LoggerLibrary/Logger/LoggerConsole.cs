using System;
using LoggerLibrary.Interface;

namespace LoggerLibrary.Logger
{
   public class LoggerConsole : ILoggerConsole
    {
        public void CreateLogConsole(string meesage, LogType.LogType logType)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Log Type: " + logType.ToString());
            Console.WriteLine("Message: " + meesage);
            Console.WriteLine("DateTime: " + DateTime.Now);
            Console.WriteLine("MachineName: " + Environment.MachineName);
            Console.WriteLine("UserName: " + Environment.UserName);
            Console.WriteLine("*************************************");
        }

    }
}
