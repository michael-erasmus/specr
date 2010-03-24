using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace specr.Reflection
{
    public static class ReflectionHelper
    {
        public static PropertyInfo GetProperty(this PropertyInfo[] properties, string name)
        {
            return properties.FirstOrDefault(p => p.Name == name);
        }        
    }
}
