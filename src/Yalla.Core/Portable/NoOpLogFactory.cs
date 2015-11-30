using System;

namespace Yalla
{
    /// <summary>
    /// No-op log factory.
    /// </summary>
    public class NoOpLogFactory : Singleton<NoOpLogFactory>, ILogFactory
    {
        static NoOpLogFactory()
        {
        }

        private readonly Log log;

        private NoOpLogFactory()
            : base(null)
        {
            this.log = new Log(NoOpLogger.Instance, DefaultFormatter.Instance);
        }

        /// <summary>
        /// Initializes the logging system.
        /// </summary>
        public void Initialize()
        {
        }

        /// <summary>
        /// Terminates the logging system.
        /// </summary>
        public void Shutdown()
        {
        }

        /// <summary>
        /// Retrieves or creates a log by name.
        /// </summary>
        /// <param name="name">The name of the log to retrieve.</param>
        /// <returns>Log.</returns>
        public ILog GetLogger(string name)
        {
            return log;
        }

        /// <summary>
        /// Retrieves or creates a log by type.
        /// </summary>
        /// <param name="type">The type to retrieve the log for.</param>
        /// <returns>Log.</returns>
        public ILog GetLogger(Type type)
        {
            return log;
        }
    }
}
