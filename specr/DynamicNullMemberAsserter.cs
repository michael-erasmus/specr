using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Reflection;

namespace specr
{
    public enum ExpectedNullability { Null, NotNull };

    public class DynamicNullMemberAsserter<T> : DynamicObject
    {
        private T obj;
        private PropertyInfo[] properties = typeof(T).GetProperties();

        public ExpectedNullability Expected { get; private set; }

        public DynamicNullMemberAsserter(T obj, ExpectedNullability expected)
        {
            Expected = expected;
            this.obj = obj;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var prop = properties.GetProperty(binder.Name);

            if (prop != null)
            {
                result = prop.GetValue(obj, null);
                switch (Expected)
                {
                    case ExpectedNullability.Null:
                        UnitTestingFramework.AssertIsNull(result);;
                        break;
                    case ExpectedNullability.NotNull:
                        UnitTestingFramework.AssertIsNotNull(result);    
                        break;
                    default:
                        break;
                }
                return true;
            }

            return base.TryInvokeMember(binder, args, out result);
        }
    }
}
