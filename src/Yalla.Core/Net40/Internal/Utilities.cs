using System;

namespace Yalla.Internal
{
    static class Utilities
    {
        public static T CreateInstance<T>()
        {
            return (T)Activator.CreateInstance(typeof(T), true);
        }
    }
}
