using System;
using System.Runtime.CompilerServices;

namespace Yalla
{
    /// <summary>
    /// Log implementation.
    /// </summary>
    public sealed class Log : ILog
    {
		#region Fields

        private readonly ILogger _logger;
        private readonly ILogFormatter _formatter;

		#endregion Fields

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="Yalla.Log"/> class.
		/// </summary>
        /// <param name="logger">Logger.</param>
        /// <param name="formatter">Log formatter.</param>
        public Log(ILogger logger, ILogFormatter formatter)
        {
            this._logger = logger;
            this._formatter = formatter;
        }

		#endregion Constructor

		#region Finalizer

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the <see cref="Yalla.Log"/>
        /// is reclaimed by garbage collection.
        /// </summary>
        ~Log()
        {
            Dispose(false);
        }

		#endregion Finalizer

		#region Dispose

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
		public void Dispose(bool disposing)
		{
			if (disposing)
				Logger.Dispose();
		}

		#endregion Dispose

		#region Trace

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Trace(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Trace(Exception exception, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Trace(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Trace(Exception exception, IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void TraceFormat(Exception exception, IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsTraceEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Trace, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Gets a value indicating whether logging of trace entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of trace entries is enabled.</value>
        public bool IsTraceEnabled
		{
			get { return Logger.IsEnabled(LogLevel.Trace); }
		}

		#endregion Trace

		#region Debug

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Debug(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Debug(Exception exception, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Debug(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Debug(Exception exception, IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsDebugEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Debug, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Gets a value indicating whether logging of debug entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of debug entries is enabled.</value>
        public bool IsDebugEnabled
		{
			get { return Logger.IsEnabled(LogLevel.Debug); }
		}

		#endregion Debug

		#region Info

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Info(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Info(Exception exception, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Info(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Info(Exception exception, IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsInfoEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Info, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Gets a value indicating whether logging of information entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of information entries is enabled.</value>
        public bool IsInfoEnabled
		{
			get { return Logger.IsEnabled(LogLevel.Info); }
		}

		#endregion Info

		#region Warn

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Warn(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Warn(Exception exception, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Warn(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Warn(Exception exception, IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsWarnEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Warn, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Gets a value indicating whether logging of warning entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of warning entries is enabled.</value>
        public bool IsWarnEnabled
		{
			get { return Logger.IsEnabled(LogLevel.Warn); }
		}

		#endregion Warn

		#region Error

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Error(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Error(Exception exception, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Error(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Error(Exception exception, IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsErrorEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Error, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Gets a value indicating whether logging of error entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of error entries is enabled.</value>
        public bool IsErrorEnabled
		{
			get { return Logger.IsEnabled(LogLevel.Error); }
		}

		#endregion Error

		#region Fatal

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Fatal(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Fatal(Exception exception, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			IFormatProvider formatProvider = null;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Fatal(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void Fatal(Exception exception, IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0, arg1 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			object[] args = new[] { arg0, arg1, arg2, arg3 };
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			string message = string.Format(formatProvider, format, args);
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			Exception exception = null;
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="exception">Exception.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
		{
			if (!IsFatalEnabled)
				return;
			string message = formatMessageCallback((format, arg) => string.Format(formatProvider, format, arg));
			CallerInfo caller = GetCallerInfo(filePath, memberName, lineNumber);
			LogEntry entry = new LogEntry(Logger.Name, LogLevel.Fatal, message, exception, caller);
			string formattedMessage = Formatter.Format(formatProvider, entry);
			Logger.Log(entry, formattedMessage, formatProvider);
		}

        /// <summary>
        /// Gets a value indicating whether logging of fatal error entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of fatal error entries is enabled.</value>
        public bool IsFatalEnabled
		{
			get { return Logger.IsEnabled(LogLevel.Fatal); }
		}

		#endregion Fatal

		#region Common Properties

        /// <summary>
        /// Gets the internal logger instance.
        /// </summary>
        /// <value>Internal logger instance.</value>
		public ILogger Logger
        {
            get { return _logger; }
        }

        /// <summary>
        /// Gets the internal formatter instance.
        /// </summary>
        /// <value>Internal formatter instance.</value>
		public ILogFormatter Formatter
        {
            get { return _formatter; }
        }

		#endregion Common Properties

		#region Private Methods

		private CallerInfo GetCallerInfo(string filePath, string memberName, int lineNumber)
		{
			return new CallerInfo(filePath, memberName, lineNumber);
		}

		#endregion Private Methods
	}
}
