using specr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace specr_specs
{       
    /// <summary>
    /// Describes the expected behaviour of the DynamicNullMemberAsserter object
    /// </summary>
    [TestClass]
    public class DescribeDynamicNullMemberAsserter
    {
        [TestMethod]
        public void It_Should_Test_If_Property_Is_Not_Null_When_HaveA_Is_Called()
        {
            var person = new Person();
            person.Father = new Person();

            dynamic dAssert = person.Should().HaveA();
            dAssert.Father();
        }

        [TestMethod]
        public void It_Should_Test_If_Property_Is_Null_When_NotHaveA_Is_Called()
        {
            var person = new Person();

            dynamic dAssert = person.Should().NotHaveA();
            dAssert.Father();
        }
    }
}
