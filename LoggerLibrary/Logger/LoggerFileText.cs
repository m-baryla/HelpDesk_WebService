using System;
using System.IO;
using LoggerLibrary.Interface;

namespace LoggerLibrary.Logger
{
    public class LoggerFileText : ILoggerFileText
    {
        private readonly string _path;

        public LoggerFileText(string path)
        {
            this._path = path;
        }
        public void CreateLogFileText(string meesage, LogType.LogType logType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                //streamWriter.WriteLine(_logType.ToString() + " " + _meesage + " " + DateTime.Now + " " + Environment.MachineName + " " + Environment.UserName);
                streamWriter.WriteLine("*************************************");
                streamWriter.WriteLine("Log Type: " + logType.ToString());
                streamWriter.WriteLine("Message: " + meesage);
                streamWriter.WriteLine("DateTime: " + DateTime.Now);
                streamWriter.WriteLine("MachineName: " + Environment.MachineName);
                streamWriter.WriteLine("UserName: " + Environment.UserName);
                streamWriter.WriteLine("*************************************");
                //streamWriter.Dispose();
            }

        }
    }
}
