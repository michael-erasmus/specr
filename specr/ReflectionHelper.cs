using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace specr
{
    public static class ReflectionHelper
    {
        public static PropertyInfo GetProperty(this PropertyInfo[] properties, string name)
        {
            return properties.FirstOrDefault(p => p.Name == name);
        }
    }
}
