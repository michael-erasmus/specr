using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace specr
{
    public static class Specr
    {
        public static Asserter<T> Should<T>(this T obj)
        {
            return new Asserter<T>(obj);
        }

        public static dynamic ShouldBe<T>(this T obj)
        {
            return new ExpandoObject();
        }
    }
}
