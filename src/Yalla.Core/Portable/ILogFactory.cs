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
        /// Retrieves or creates a named log.
        /// </summary>
        /// <param name="name">The name of the log to retrieve.</param>
        ILog GetLogger(string name);

        /// <summary>
        /// Retrieves or creates a named log.
        /// </summary>
        /// <param name="type">The type to retrieve the log for.</param>
        ILog GetLogger(Type type);
    }
}
