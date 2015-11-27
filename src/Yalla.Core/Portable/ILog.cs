using System;
using System.Runtime.CompilerServices;

namespace Yalla
{
    /// <summary>
    /// Log interface.
    /// </summary>
    public interface ILog : IDisposable
    {
		#region Trace

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Trace(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Trace(object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void TraceFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void TraceFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Trace(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Trace(IFormatProvider formatProvider, object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void TraceFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void TraceFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void TraceFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new trace entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void TraceFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Gets a value indicating whether logging of trace entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of trace entries is enabled.</value>
        bool IsTraceEnabled { get; }

		#endregion Trace

		#region Debug

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Debug(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Debug(object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void DebugFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void DebugFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Debug(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Debug(IFormatProvider formatProvider, object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void DebugFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void DebugFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void DebugFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new debug entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void DebugFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Gets a value indicating whether logging of debug entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of debug entries is enabled.</value>
        bool IsDebugEnabled { get; }

		#endregion Debug

		#region Info

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Info(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Info(object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void InfoFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void InfoFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Info(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Info(IFormatProvider formatProvider, object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void InfoFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void InfoFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void InfoFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new information entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void InfoFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Gets a value indicating whether logging of information entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of information entries is enabled.</value>
        bool IsInfoEnabled { get; }

		#endregion Info

		#region Warn

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Warn(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Warn(object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void WarnFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void WarnFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Warn(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Warn(IFormatProvider formatProvider, object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void WarnFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void WarnFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void WarnFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new warning entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void WarnFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Gets a value indicating whether logging of warning entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of warning entries is enabled.</value>
        bool IsWarnEnabled { get; }

		#endregion Warn

		#region Error

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Error(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Error(object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void ErrorFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void ErrorFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Error(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Error(IFormatProvider formatProvider, object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void ErrorFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void ErrorFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Gets a value indicating whether logging of error entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of error entries is enabled.</value>
        bool IsErrorEnabled { get; }

		#endregion Error

		#region Fatal

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Fatal(object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Fatal(object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void FatalFormat(string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void FatalFormat(string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Fatal(IFormatProvider formatProvider, object message, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void Fatal(IFormatProvider formatProvider, object message, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void FatalFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void FatalFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

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
		void FatalFormat(IFormatProvider formatProvider, string format, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="arg0">Format argument 0.</param>
        /// <param name="arg1">Format argument 1.</param>
        /// <param name="arg2">Format argument 2.</param>
        /// <param name="arg3">Format argument 3.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, object arg0, object arg1, object arg2, object arg3, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="format">Message format.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="args">Format arguments.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, object[] args, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a new fatal error entry.
        /// </summary>
        /// <param name="formatProvider">Format provider.</param>
        /// <param name="formatMessageCallback">Format message callback delegate.</param>
        /// <param name="exception">Exception.</param>
        /// <param name="filePath">File path (populated by the compiler).</param>
        /// <param name="memberName">Member name (populated by the compiler).</param>
        /// <param name="lineNumber">Line number (populated by the compiler).</param>
		void FatalFormat(IFormatProvider formatProvider, FormatMessageCallback formatMessageCallback, Exception exception, [CallerFilePath] string filePath = null, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Gets a value indicating whether logging of fatal error entries is enabled.
        /// </summary>
        /// <value><c>true</c> if logging of fatal error entries is enabled.</value>
        bool IsFatalEnabled { get; }

		#endregion Fatal

		#region Common Properties

        /// <summary>
        /// Gets the internal logger instance.
        /// </summary>
        /// <value>Internal logger instance.</value>
		ILogger Logger { get; }

        /// <summary>
        /// Gets the internal formatter instance.
        /// </summary>
        /// <value>Internal formatter instance.</value>
		ILogFormatter Formatter { get; }

		#endregion Common Properties
	}
}
