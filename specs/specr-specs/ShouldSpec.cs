using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using specr;

namespace specr_specs
{
    /// <summary>
    /// Describes the Should() Extension method in the specr namespace
    /// </summary>
    [TestClass]
    public class DescribeShould
    {             
        [TestMethod]
        public void It_Should_Return_An_Asserter()
        {
            var obj = new Object();
            var dAssert = obj.Should();
            dAssert.Should().BeAn<Asserter<object>>();
        }
        
    }
}
