using System;

namespace Yalla
{
    /// <summary>
    /// Log formatter interface.
    /// </summary>
    public interface ILogFormatter
    {
        /// <summary>
        /// Formats an entry.
        /// </summary>
        /// <param name="provider">Format provider.</param>
        /// <param name="entry">The entry.</param>
        /// <returns>Formatted entry.</returns>
        string Format(IFormatProvider provider, LogEntry entry);

        /// <summary>
        /// Gets the prologue.
        /// </summary>
        /// <value>Prologue.</value>
        string Prologue { get; }

        /// <summary>
        /// Gets the epilogue.
        /// </summary>
        /// <value>Epilogue.</value>
        string Epilogue { get; }
    }
}
