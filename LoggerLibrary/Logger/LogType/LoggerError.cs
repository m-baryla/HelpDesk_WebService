using System.Diagnostics;
using LoggerLibrary.Interface;

namespace LoggerLibrary.Logger.LogType
{
    class LoggerError
    {
        private readonly ILoggerWindowsEvent _loggerWindowsEvent;
        private readonly ILoggerFileText _loggerFileText;
        private readonly ILoggerConsole _loggerConsole;

        #region Constructor
        public LoggerError(ILoggerWindowsEvent loggerWindowsEvent)
        {
            this._loggerWindowsEvent = loggerWindowsEvent;
        }
        public LoggerError(ILoggerFileText loggerFileText)
        {
            this._loggerFileText = loggerFileText;
        }
        public LoggerError(ILoggerConsole loggerConsole)
        {
            this._loggerConsole = loggerConsole;
        }
        #endregion


        #region LoggerMethod
        public void LoggerErrorWindowsEvent(string infoMessage, int category)
        {
            _loggerWindowsEvent.CreateSourceWindowsEvent(EventLogEntryType.Error);
            _loggerWindowsEvent.CreateLogWindowsEvent(infoMessage, category);
        }
        public void LogErrorText(string meesage)
        {
            _loggerFileText.CreateLogFileText(meesage, LogType.Error);
        }
        public void LogErrorConsole(string meesage)
        {
            _loggerConsole.CreateLogConsole(meesage, LogType.Error);
        }
        #endregion


    }
}
