using System;
using System.Collections.Generic;

namespace Yalla
{
    /// <summary>
    /// Log entry.
    /// </summary>
    public class LogEntry
    {
        /// <summary>
        /// Creates an instance of the <see cref="Yalla.LogEntry"/> class.
        /// </summary>
        /// <param name="name">Log name.</param>
        /// <param name="level">Log level.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="caller">Caller information.</param>
        public LogEntry(string name, LogLevel level, object message, Exception exception, CallerInfo caller)
        {
            Timestamp = DateTime.Now;
            Name = name;
            Level = level;
            Message = message;
            Exception = exception;
            Caller = caller;
        }

        /// <summary>
        /// Timestamp.
        /// </summary>
        public DateTime Timestamp
        {
            get;
            set;
        }

        /// <summary>
        /// Log name.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Log level.
        /// </summary>
        public LogLevel Level
        {
            get;
            set;
        }

        /// <summary>
        /// Message.
        /// </summary>
        public object Message
        {
            get;
            set;
        }

        /// <summary>
        /// Exception.
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Caller information.
        /// </summary>
        public CallerInfo Caller
        {
            get;
            set;
        }

        /// <summary>
        /// Additional properties.
        /// </summary>
        public IDictionary<string, object> Properties
        {
            get;
            set;
        }
    }
}
