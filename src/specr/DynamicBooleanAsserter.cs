using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Reflection;
using specr.Reflection;

namespace specr
{
    public class DynamicBooleanAsserter<TObj> : DynamicAsserter<TObj, bool>
    {
        public DynamicBooleanAsserter(TObj obj, bool expected)
            : base(obj, expected)
        {
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
            else if (binder.Name == "Null")
            {                
                result = obj.IsNull();
                result.Should().Equal(Expected);
                return true;
            }

            return base.TryInvokeMember(binder, args, out result);
        }
    }
}
