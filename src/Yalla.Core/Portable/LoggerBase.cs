using System;

namespace Yalla
{
    /// <summary>
    /// Base logger.
    /// </summary>
	public abstract class LoggerBase : ILogger
    {
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Yalla.LoggerBase"/> class.
        /// </summary>
        /// <param name="name">The name of the logger.</param>
        protected LoggerBase(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Releases unmanaged resources and performs other cleanup operations before the <see cref="Yalla.LoggerBase"/>
        /// is reclaimed by garbage collection.
        /// </summary>
        ~LoggerBase()
        {
            Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
		{
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
        }

        /// <summary>
        /// Logs an entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <param name="message">The message.</param>
        /// <param name="provider">Format provider.</param>
        public abstract void Log(LogEntry entry, string message, IFormatProvider provider);

        /// <summary>
        /// Gets a value indicating whether logging of entries of the specified level is enabled.
        /// </summary>
        /// <param name="logLevel">Log level.</param>
        /// <returns><c>true</c> if logging of entries of the specified level is enabled.</returns>
        public abstract bool IsEnabled(LogLevel logLevel);

        /// <summary>
        /// Gets the name of the logger.
        /// </summary>
        /// <value>The name of the logger.</value>
        public string Name
        {
            get { return _name; }
        }
    }

    /// <summary>
    /// Base logger.
    /// </summary>
    /// <typeparam name="TLevel">The type of the concrete log level.</typeparam>
    public abstract class LoggerBase<TLevel> : LoggerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Yalla.LoggerBase"/> class.
        /// </summary>
        /// <param name="name">The name of the logger.</param>
        protected LoggerBase(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Logs an entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <param name="message">The message.</param>
        /// <param name="provider">Format provider.</param>
        public override void Log(LogEntry entry, string message, IFormatProvider provider)
        {
            var level = GetLevel(entry.Level);
            Log(level, entry, message, provider);
        }

        /// <summary>
        /// Gets a value indicating whether logging of entries of the specified level is enabled.
        /// </summary>
        /// <param name="logLevel">Log level.</param>
        /// <returns><c>true</c> if logging of entries of the specified level is enabled.</returns>
        public override bool IsEnabled(LogLevel logLevel)
        {
            if (!IsEnabled())
                return false;
            var level = GetLevel(logLevel);
            return IsEnabled(level);
        }

        /// <summary>
        /// Gets a value indicating whether this logger is enabled.
        /// </summary>
        /// <returns><c>true</c> if this logger is enabled.</returns>
        protected virtual bool IsEnabled()
        {
            return true;
        }

        /// <summary>
        /// Logs an entry.
        /// </summary>
        /// <param name="level">Log level.</param>
        /// <param name="entry">The entry.</param>
        /// <param name="message">The message.</param>
        /// <param name="provider">Format provider.</param>
        protected abstract void Log(TLevel level, LogEntry entry, string message, IFormatProvider provider);

        /// <summary>
        /// Gets a value indicating whether logging of entries of the specified level is enabled.
        /// </summary>
        /// <param name="level">Log level.</param>
        /// <returns><c>true</c> if logging of entries of the specified level is enabled.</returns>
        protected abstract bool IsEnabled(TLevel level);

        /// <summary>
        /// Gets the concrete log level.
        /// </summary>
        /// <param name="logLevel">Yalla log level.</param>
        /// <returns>Log level.</returns>
        protected abstract TLevel GetLevel(LogLevel logLevel);
    }

    /// <summary>
    /// Base logger.
    /// </summary>
    /// <typeparam name="TLevel">The type of the concrete log level.</typeparam>
    /// <typeparam name="TSettings">The type of the logger settings.</typeparam>
    public abstract class LoggerBase<TLevel, TSettings> : LoggerBase<TLevel>
        where TSettings : LoggerSettings
    {
        private readonly TSettings _settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="Yalla.LoggerBase"/> class.
        /// </summary>
        /// <param name="name">The name of the logger.</param>
        /// <param name="settings">Logger settings.</param>
        protected LoggerBase(string name, TSettings settings)
            : base(name)
        {
            this._settings = settings;
        }

        /// <summary>
        /// Gets a value indicating whether entries of the specified level or above should be logged.
        /// </summary>
        /// <param name="logLevel">The log level to check.</param>
        /// <returns><c>true</c> if entries of the specified level or above should be logged.</returns>
        public override bool IsEnabled(LogLevel logLevel)
        {
            if (!IsEnabled() || logLevel < Level)
                return false;
            var level = GetLevel(logLevel);
            return IsEnabled(level);
        }

        /// <summary>
        /// Gets a value indicating whether this logger is enabled.
        /// </summary>
        /// <param name="level">Log level.</param>
        /// <returns><c>true</c> if this logger is enabled.</returns>
        protected override bool IsEnabled(TLevel level)
        {
            return true;
        }

        /// <summary>
        /// Gets the logger settings.
        /// </summary>
        /// <value>Logger settings.</value>
        protected TSettings Settings
        {
            get { return _settings; }
        }

        /// <summary>
        /// Gets the minimum enabled log level.
        /// </summary>
        /// <value>Minimum enabled log level.</value>
        protected LogLevel Level
        {
            get { return Settings.Level; }
        }
    }
}
