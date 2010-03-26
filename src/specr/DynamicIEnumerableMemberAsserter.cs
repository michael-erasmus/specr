using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using specr.Reflection;

namespace specr
{
    public class DynamicIEnumerableMemberAsserter<TObj> : DynamicAsserter<TObj, int>
    {
        public DynamicIEnumerableMemberAsserter(TObj obj, int expected)
            :base(obj, expected)
        {

        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
             var prop = properties.GetProperty(binder.Name);

             if (prop != null)
             {
                 result = prop.GetValue(obj, null) as IEnumerable<TObj>;

                 if (result != null)
                 {
                     UnitTestingFramework.AssertAreEqual<int>(Expected, (result as IEnumerable<TObj>).Count());
                     return true;
                 }
             }

            return base.TryInvokeMember(binder, args, out result);
        }
    }
}
