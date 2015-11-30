using System;

namespace Yalla
{
    class NoOpLogger : LoggerBase
    {
        static NoOpLogger()
        {
        }

        public static NoOpLogger Instance
        {
            get { return Singleton<NoOpLogger>.Instance; }
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
    public class NoOpLoggerFactoryAdapter : Singleton<NoOpLoggerFactoryAdapter>, ILoggerFactoryAdapter
    {

        private NoOpLoggerFactoryAdapter()
            : base(null)
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
