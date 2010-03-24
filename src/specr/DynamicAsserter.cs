using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Reflection;

namespace specr
{
    public abstract class DynamicAsserter<TObj, TExpected> : DynamicObject
    {
        protected TObj obj;
        protected PropertyInfo[] properties = typeof(TObj).GetProperties();

        public TExpected Expected { get; private set; }

        public DynamicAsserter(TObj obj, TExpected expected)
        {
            this.obj = obj;
            Expected = expected;
        }

        public void OfType<TExpected>()
        {
            obj.Should().BeA<TExpected>();
        }
    }
}
