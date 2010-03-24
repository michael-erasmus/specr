using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using specr;

namespace specr_specs
{
    [TestClass]
    public class DescribeIsNull
    {
        [TestMethod]
        public void It_Should_Return_True_If_An_Object_Is_Null()
        {
            object nullObj = null;

            nullObj.IsNull().Should().Equal(true);
        }

        [TestMethod]
        public void It_Should_Return_False_If_An_Object_Is_Null()
        {
            object nullObj = new object();

            nullObj.IsNull().Should().Equal(false);
        }
    }
}
