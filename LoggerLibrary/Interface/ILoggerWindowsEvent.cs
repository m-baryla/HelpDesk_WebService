using System.Diagnostics;

namespace LoggerLibrary.Interface
{
    interface ILoggerWindowsEvent
    {
        void CreateLogWindowsEvent(string infoMessage, int category);
        void CreateSourceWindowsEvent(EventLogEntryType eventLogEntryType);
    }
}
