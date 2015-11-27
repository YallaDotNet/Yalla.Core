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
        /// Initializes a new instance of the <see cref="Yalla.LogEntry"/> class.
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
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>Timestamp.</value>
        public DateTime Timestamp
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the log name.
        /// </summary>
        /// <value>Log name.</value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the log level.
        /// </summary>
        /// <value>Log level.</value>
        public LogLevel Level
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>Message.</value>
        public object Message
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>Exception.</value>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the caller information.
        /// </summary>
        /// <value>Caller information.</value>
        public CallerInfo Caller
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the additional properties.
        /// </summary>
        /// <value>Additional properties.</value>
        public IDictionary<string, object> Properties
        {
            get;
            set;
        }
    }
}
