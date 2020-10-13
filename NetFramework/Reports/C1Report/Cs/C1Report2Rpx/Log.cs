using System;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace C1Report2Rpx
{
    public enum LogEntryLevel
    {
        None,
        Message,
        Warning,
        Error,
        Fatal,
    }

    public class LogEntry
    {
        private LogEntryLevel _level;
        private string _source;
        private string _message;

        #region Constructors
        public LogEntry(
            LogEntryLevel level,
            string source,
            string message)
        {
            _level = level;
            _source = source;
            _message = message;
        }

        public LogEntry(
            LogEntryLevel level,
            string message)
            : this(level, null, message)
        {
        }
        #endregion

        #region Public
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (_level > LogEntryLevel.None)
            {
                result.Append(_level);
                result.Append(", ");
            }
            if (!string.IsNullOrEmpty(_source))
            {
                result.Append(_source);
                result.Append(", ");
            }
            result.Append(_message);
            return result.ToString();
        }
        #endregion

        #region Public properties
        public LogEntryLevel Level
        {
            get { return _level; }
        }

        public string Source
        {
            get { return _source; }
        }

        public string Message
        {
            get { return _message; }
        }
        #endregion
    }

    public class Log : List<LogEntry>
    {
        #region Public
        public LogEntry Add(
            LogEntryLevel level,
            string source,
            string message)
        {
            LogEntry result = new LogEntry(level, source, message);
            Add(result);
            return result;
        }

        public LogEntry Add(
            LogEntryLevel level,
            string message)
        {
            return Add(level, null, message);
        }

        public LogInfo GetInfo()
        {
            LogInfo result = new LogInfo();
            foreach (LogEntry le in this)
                switch (le.Level)
                {
                    case LogEntryLevel.Error:
                        result.ErrorCount++;
                        break;
                    case LogEntryLevel.Warning:
                        result.WarningCount++;
                        break;
                }
            return result;
        }
        #endregion
    }

    public struct LogInfo
    {
        public int WarningCount;
        public int ErrorCount;

        #region Public properties
        public string Description
        {
            get
            {
                if (WarningCount == 0 && ErrorCount == 0)
                    return Strings.ConvertingStatus.Success;
                if (WarningCount == 0)
                    return string.Format(Strings.ConvertingStatus.Errors, ErrorCount);
                if (ErrorCount == 0)
                    return string.Format(Strings.ConvertingStatus.Warnings, WarningCount);
                return string.Format(Strings.ConvertingStatus.ErrorsAndWarnings, ErrorCount, WarningCount);
            }
        }

        public Image Image
        {
            get
            {
                if (ErrorCount > 0)
                    return Util.ImgError;
                if (WarningCount > 0)
                    return Util.ImgWarning;
                return Util.ImgSuccess;
            }
        }
        #endregion
    }
}
