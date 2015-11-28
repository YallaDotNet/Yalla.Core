using System;

namespace Yalla
{
    /// <summary>
    /// Log factory interface.
    /// </summary>
    public interface ILogFactory
    {
        /// <summary>
        /// Initializes the logging system.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Terminates the logging system.
        /// </summary>
        void Shutdown();

        /// <summary>
        /// Retrieves or creates a log by name.
        /// </summary>
        /// <param name="name">The name of the log to retrieve.</param>
        /// <returns>Log.</returns>
        ILog GetLogger(string name);

        /// <summary>
        /// Retrieves or creates a log by type.
        /// </summary>
        /// <param name="type">The type to retrieve the log for.</param>
        /// <returns>Log.</returns>
        ILog GetLogger(Type type);
    }
}
