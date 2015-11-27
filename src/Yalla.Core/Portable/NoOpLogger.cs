using System;

namespace Yalla
{
    class NoOpLogger : LoggerBase
    {
        private static readonly Lazy<NoOpLogger> _lazy;

        static NoOpLogger()
        {
            _lazy = new Lazy<NoOpLogger>(() => new NoOpLogger());
        }

        public static NoOpLogger Instance
        {
            get { return _lazy.Value; }
        }

        private NoOpLogger()
            : base(null)
        {
        }

        public override void Log(LogEntry entry, string message, IFormatProvider formatProvider)
        {
        }

        public override bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }
    }

    /// <summary>
    /// No-op logger factory adapter.
    /// </summary>
    public class NoOpLoggerFactoryAdapter : ILoggerFactoryAdapter
    {
        private static readonly Lazy<NoOpLoggerFactoryAdapter> _lazy;

        static NoOpLoggerFactoryAdapter()
        {
            _lazy = new Lazy<NoOpLoggerFactoryAdapter>(() => new NoOpLoggerFactoryAdapter());
        }

        /// <summary>
        /// Gets an instance of the <see cref="Yalla.NoOpLoggerFactoryAdapter"/> class.
        /// </summary>
        /// <value>The instance.</value>
        public static NoOpLoggerFactoryAdapter Instance
        {
            get { return _lazy.Value; }
        }

        private NoOpLoggerFactoryAdapter()
        {
        }

        /// <summary>
        /// Initializes the logging system.
        /// </summary>
        /// <param name="prologue">Prologue.</param>
        public void Initialize(string prologue)
        {
        }

        /// <summary>
        /// Terminates the logging system.
        /// </summary>
        /// <param name="epilogue">Epilogue.</param>
        public void Shutdown(string epilogue)
        {
        }

        /// <summary>
        /// Gets a logger instance by name.
        /// </summary>
        /// <param name="name">The name of the logger.</param>
        /// <returns>Logger.</returns>
        public ILogger GetLogger(string name)
        {
            return NoOpLogger.Instance;
        }

        /// <summary>
        /// Gets a logger instance by type.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>Logger.</returns>
        public ILogger GetLogger(Type type)
        {
            return NoOpLogger.Instance;
        }
    }
}
