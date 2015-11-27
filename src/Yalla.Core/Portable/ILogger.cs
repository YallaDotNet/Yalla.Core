using System;

namespace Yalla
{
    /// <summary>
    /// Logger interface.
    /// </summary>
	public interface ILogger : IDisposable
    {
        /// <summary>
        /// Logs an entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <param name="message">The message.</param>
        /// <param name="provider">Format provider.</param>
        void Log(LogEntry entry, string message, IFormatProvider provider);

        /// <summary>
        /// Gets a value indicating whether logging of entries of the specified level is enabled.
        /// </summary>
        /// <param name="logLevel">Log level.</param>
        /// <returns><c>true</c> if logging of entries of the specified level is enabled.</returns>
        bool IsEnabled(LogLevel logLevel);

        /// <summary>
        /// Gets the name of the logger.
        /// </summary>
        /// <value>The name of the logger.</value>
        string Name { get; }
    }
}
