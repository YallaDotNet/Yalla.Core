using System;

namespace Yalla
{
    /// <summary>
    /// Base class for logger factory adapters.
    /// </summary>
    public abstract class LoggerFactoryAdapterBase : ILoggerFactoryAdapter
    {
        /// <summary>
        /// Initializes the logging system.
        /// </summary>
        /// <param name="prologue">Prologue.</param>
        public abstract void Initialize(string prologue);

        /// <summary>
        /// Terminates the logging system.
        /// </summary>
        /// <param name="epilogue">Epilogue.</param>
        public abstract void Shutdown(string epilogue);

        /// <summary>
        /// Gets a logger instance by name.
        /// </summary>
        /// <param name="name">The name of the logger.</param>
        /// <returns>Logger.</returns>
        public abstract ILogger GetLogger(string name);

        /// <summary>
        /// Gets a logger instance by type.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>Logger.</returns>
        public virtual ILogger GetLogger(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");
            return GetLogger(type.FullName);
        }
    }

    /// <summary>
    /// Base class for logger factory adapters.
    /// </summary>
    public abstract class LoggerFactoryAdapterBase<TSettings> : LoggerFactoryAdapterBase
        where TSettings : class, new()
    {
        private TSettings _settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="Yalla.LoggerFactoryAdapterBase"/> class.
        /// </summary>
        protected LoggerFactoryAdapterBase()
	    {
	    }

        /// <summary>
        /// Initializes a new instance of the <see cref="Yalla.LoggerFactoryAdapterBase"/> class.
        /// </summary>
        /// <param name="settings">Logger settings.</param>
        protected LoggerFactoryAdapterBase(TSettings settings)
        {
            this._settings = settings;
        }

        /// <summary>
        /// Gets or sets the logger settings.
        /// </summary>
        /// <value>Logger settings.</value>
        public TSettings Settings
        {
            get
            {
                return _settings ?? (_settings = CreateSettings());
            }
            set { _settings = value; }
        }

        /// <summary>
        /// Creates the logger settings.
        /// </summary>
        /// <value>Logger settings.</value>
        protected virtual TSettings CreateSettings()
        {
            return new TSettings();
        }
    }
}
