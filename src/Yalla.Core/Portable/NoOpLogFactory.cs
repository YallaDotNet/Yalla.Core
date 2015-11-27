using System;

namespace Yalla
{
    /// <summary>
    /// No-op log factory.
    /// </summary>
    public class NoOpLogFactory : ILogFactory
    {
        private static readonly Lazy<NoOpLogFactory> _lazy;

        static NoOpLogFactory()
        {
            _lazy = new Lazy<NoOpLogFactory>(() => new NoOpLogFactory());
        }

        /// <summary>
        /// Gets an instance of the <see cref="Yalla.NoOpLogFactory"/> class.
        /// </summary>
        /// <value>The instance.</value>
        public static NoOpLogFactory Instance
        {
            get { return _lazy.Value; }
        }

        private readonly Log log;

        private NoOpLogFactory()
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
        /// Retrieves or creates a named log.
        /// </summary>
        /// <param name="name">The name of the log to retrieve.</param>
        /// <returns>Log.</returns>
        public ILog GetLogger(string name)
        {
            return log;
        }

        /// <summary>
        /// Retrieves or creates a named log.
        /// </summary>
        /// <param name="type">The type to retrieve the log for.</param>
        /// <returns>Log.</returns>
        public ILog GetLogger(Type type)
        {
            return log;
        }
    }
}
