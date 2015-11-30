using System;
using System.Linq;
using System.Reflection;

namespace Yalla.Internal
{
    static class Utilities
    {
        public static T CreateInstance<T>()
        {
            var typeInfo = typeof(T).GetTypeInfo();
            var ctor = typeInfo.DeclaredConstructors.SingleOrDefault(c => !c.IsStatic && c.GetParameters().Length == 0);
            if (ctor == null)
                throw new MissingMemberException("No parameterless constructor is defined for this type.");
            return (T)ctor.Invoke(null);
        }
    }
}
