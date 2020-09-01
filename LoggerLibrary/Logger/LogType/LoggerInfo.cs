using System.Diagnostics;
using LoggerLibrary.Interface;

namespace LoggerLibrary.Logger.LogType
{
    class LoggerInfo
    {
        private readonly ILoggerWindowsEvent _loggerWindowsEvent;
        private readonly ILoggerFileText _loggerFileText;
        private readonly ILoggerConsole _loggerConsole;


        #region Constructor

        public LoggerInfo(ILoggerWindowsEvent loggerWindowsEvent)
        {
            this._loggerWindowsEvent = loggerWindowsEvent;
        }
        public LoggerInfo(ILoggerFileText loggerFileText)
        {
            this._loggerFileText = loggerFileText;
        }
        public LoggerInfo(ILoggerConsole loggerConsole)
        {
            this._loggerConsole = loggerConsole;
        }
        #endregion

        #region LoggerMethod

        public void LoggerInfoWindowsEvent(string infoMessage, int category)
        {
            _loggerWindowsEvent.CreateSourceWindowsEvent(EventLogEntryType.Information);
            _loggerWindowsEvent.CreateLogWindowsEvent(infoMessage, category);
        }
        public void LoggerInfoText(string meesage)
        {
            _loggerFileText.CreateLogFileText(meesage, LogType.Information);
        }
        public void LoggerInfoConsole(string meesage)
        {
            _loggerConsole.CreateLogConsole(meesage, LogType.Information);
        }
        #endregion

    }
}
