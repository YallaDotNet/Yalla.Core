using System;

namespace Yalla
{
    /// <summary>
    /// Thread-safe singleton.
    /// </summary>
    /// <typeparam name="T">Type of instance.</typeparam>
    public class Singleton<T>
    {
        private static readonly Lazy<T> _lazy;

        static Singleton()
        {
            _lazy = new Lazy<T>(CreateInstance);
        }

        private static T CreateInstance()
        {
            return Internal.Utilities.CreateInstance<T>();
        }

        /// <summary>
        /// Deriving classes should define a non-public parameterless constructor.
        /// </summary>
        /// <param name="dummy">Ignored; safe to pass <c>null</c>.</param>
        protected Singleton(object dummy)
        {
        }

        /// <summary>
        /// Gets an instance of <typeparamref name="T"/>.
        /// </summary>
        /// <value>The instance.</value>
        public static T Instance
        {
            get { return _lazy.Value; }
        }
    }
}
