using LoggerLibrary.Logger.LogType;

namespace LoggerLibrary.Logger
{
    public class LoggerUseTools 
    {
        public LoggerUseTools(string logSource)
        {
            this._logSource = logSource;
        }

        private readonly string _logName = "DataBaseLayerWebService";
        public string _logSource;
        private readonly string _maschineName = ".";
        private readonly int _msgId = 1;
        private readonly int _informationMsgId = 1;

        private readonly int _categoryInfo = 1;
        private readonly int _categoryError = 0;
        private readonly int _categoryWarning = 2;
        private readonly string _patchInfo = "D:\\Source\\HelpDeskProject\\log_info.txt";
        private readonly string _patchError = "D:\\Source\\HelpDeskProject\\log_error.txt";
        private readonly string _patchWarning = "D:\\Source\\HelpDeskProject\\log_warning.txt";


        public void ErrorLog(string measgeError)
        {
            var loggerErrorWindowsEvent = new LoggerError(new LoggerWindowsEvent(_logName, _logSource, _maschineName, _msgId, _informationMsgId));
            var loggerErrorText = new LoggerError(new LoggerFileText(_patchError));
            var loggerErrorConsole = new LoggerError(new LoggerConsole());

            loggerErrorWindowsEvent.LoggerErrorWindowsEvent(measgeError, _categoryError);
            loggerErrorText.LogErrorText(measgeError);
            loggerErrorConsole.LogErrorConsole(measgeError);
        }
        public void InfoLog(string measgeInfo)
        {

            var loggerInfoWindowsEvent = new LoggerInfo(new LoggerWindowsEvent(_logName, _logSource, _maschineName, _msgId, _informationMsgId));
            var loggerInfoText = new LoggerInfo(new LoggerFileText(_patchInfo));
            var loggerInfoConsole = new LoggerInfo(new LoggerConsole());

            loggerInfoWindowsEvent.LoggerInfoWindowsEvent(measgeInfo, _categoryInfo);
            loggerInfoText.LoggerInfoText(measgeInfo);
            loggerInfoConsole.LoggerInfoConsole(measgeInfo);
        }
        public void WarningLog(string measgeInfo)
        {

            var loggerWarningWindowsEvent = new LoggerWarning(new LoggerWindowsEvent(_logName, _logSource, _maschineName, _msgId, _informationMsgId));
            var loggerWarningText = new LoggerWarning(new LoggerFileText(_patchWarning));
            var loggerWarningConsole = new LoggerWarning(new LoggerConsole());

            loggerWarningWindowsEvent.LoggerWarningWindowsEvent(measgeInfo, _categoryWarning);
            loggerWarningText.LoggerWarningText(measgeInfo);
            loggerWarningConsole.LoggerWarningConsole(measgeInfo);
        }
    }
}
