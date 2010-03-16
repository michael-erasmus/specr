using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Reflection;

namespace specr
{
    public class DynamicBooleanAsserter<T> : DynamicObject
    {
        private T obj;
        private PropertyInfo[] properties = typeof(T).GetProperties();


        public DynamicBooleanAsserter(T obj, bool expected)
        {
            this.obj = obj;
            Expected = expected;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var prop = properties.GetProperty(string.Format("Is{0}", binder.Name));            

            if (prop != null)
	        {
                result = prop.GetValue(obj, null);
                result.Should().Equal(Expected);
                return true;
            }

            return base.TryInvokeMember(binder, args, out result);
        }

        public bool Expected { get; private set; }
    }
}
