using System.Diagnostics;
using LoggerLibrary.Interface;

namespace LoggerLibrary.Logger
{
    class LoggerWindowsEvent : ILoggerWindowsEvent
    {

        public string LogName { get; set; }
        public string LogSource { get; set; }
        public string MaschineName { get; set; }
        public int MsgId { get; set; }
        public int InformationMsgId { get; set; }
        public EventLogEntryType EventLogEntryTypeCreate { get; set; }
        public EventLog EventLogCreate { get; set; }
        public EventInstance EventInstanceCreate { get; set; }

        public LoggerWindowsEvent(string logName, string logSource, string maschineName, int msgId, int informationMsgId)
        {
            this.LogName = logName;
            this.LogSource = logSource;
            this.MaschineName = maschineName;
            this.MsgId = msgId;
            this.InformationMsgId = informationMsgId;
        }

        public virtual void CreateSourceWindowsEvent(EventLogEntryType eventLogEntryType)
        {
            this.EventLogEntryTypeCreate = eventLogEntryType;
            EventLogCreate = new EventLog(LogName, MaschineName, LogSource);
            EventInstanceCreate = new EventInstance(InformationMsgId, MsgId, EventLogEntryTypeCreate);

            if (!EventLog.SourceExists(LogName))
            {

                if (LogName != string.Empty || LogSource != string.Empty)
                    System.Diagnostics.EventLog.CreateEventSource(LogSource, LogName);
            }
        }
        public virtual void CreateLogWindowsEvent(string infoMessage, int category)
        {
            if (EventLog.SourceExists(LogSource))
            {
                EventLogCreate.WriteEvent(EventInstanceCreate, infoMessage, category);
            }
            else if (!EventLog.SourceExists(LogSource))
            {
                EventLogCreate.WriteEvent(EventInstanceCreate, infoMessage, category);
            }
        }
    }
}
