using LoggerLibrary.Logger.LogType;

namespace LoggerLibrary.Interface
{
    internal interface ILoggerConsole
    {
        void CreateLogConsole(string meesage, LogType logType);
    }
}