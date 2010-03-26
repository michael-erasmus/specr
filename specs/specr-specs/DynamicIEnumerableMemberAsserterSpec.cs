using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using specr;

namespace specr_specs
{
    [TestClass]
    public class DynamicIEnumerableMemberAsserterSpec
    {
        private Person person;

        [TestInitialize]
        public void Before()
        {
            person = new Person();
            person.Children = new List<Person>{new Person(), new Person(), new Person()};
        }

        [TestMethod]
        public void It_Should_Test_A_IEnumerable_With_Count_Given_Exists()
        {
            person.Should().Have(3).Children();
        }
    }
}
