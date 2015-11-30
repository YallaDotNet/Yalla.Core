using System;
using System.Linq;
using System.Reflection;

namespace Yalla.Internal
{
    class Utilities
    {
        public static T CreateInstance<T>()
        {
            var ctor = typeof(T).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance)
                .SingleOrDefault(c => c.GetParameters().Length == 0);
            if (ctor == null)
                throw new MissingMemberException("No parameterless constructor is defined for this type.");
            return (T)ctor.Invoke(null);
        }
    }
}
