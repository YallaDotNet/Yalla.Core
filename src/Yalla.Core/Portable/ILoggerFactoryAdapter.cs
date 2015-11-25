using System;

namespace Yalla
{
    /// <summary>
    /// Logger factory adapter interface.
    /// </summary>
    public interface ILoggerFactoryAdapter
    {
        /// <summary>
        /// Initializes the logging system.
        /// </summary>
        /// <param name="prologue">Prologue.</param>
        void Initialize(string prologue);

        /// <summary>
        /// Terminates the logging system.
        /// </summary>
        /// <param name="epilogue">Epilogue.</param>
        void Shutdown(string epilogue);

        /// <summary>
        /// Gets a logger instance by name.
        /// </summary>
        /// <param name="name">The name of the logger.</param>
        ILogger GetLogger(string name);

        /// <summary>
        /// Gets a logger instance by type.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        ILogger GetLogger(Type type);
    }
}
