using System.Diagnostics;
using LoggerLibrary.Interface;

namespace LoggerLibrary.Logger.LogType
{
    class LoggerWarning
    {
        private readonly ILoggerWindowsEvent _loggerWindowsEvent;
        private readonly ILoggerFileText _loggerFileText;
        private readonly ILoggerConsole _loggerConsole;


        #region Constructor
        public LoggerWarning(ILoggerWindowsEvent loggerWindowsEvent)
        {
            this._loggerWindowsEvent = loggerWindowsEvent;
        }
        public LoggerWarning(ILoggerFileText loggerFileText)
        {
            this._loggerFileText = loggerFileText;
        }
        public LoggerWarning(ILoggerConsole loggerConsole)
        {
            this._loggerConsole = loggerConsole;
        }
        #endregion

        #region LoggerMethod
        public void LoggerWarningWindowsEvent(string infoMessage, int category)
        {
            _loggerWindowsEvent.CreateSourceWindowsEvent(EventLogEntryType.Warning);
            _loggerWindowsEvent.CreateLogWindowsEvent(infoMessage, category);
        }
        public void LoggerWarningText(string meesage)
        {
            _loggerFileText.CreateLogFileText(meesage, LogType.Warning);
        }
        public void LoggerWarningConsole(string meesage)
        {
            _loggerConsole.CreateLogConsole(meesage, LogType.Warning);
        }
        #endregion

    }
}