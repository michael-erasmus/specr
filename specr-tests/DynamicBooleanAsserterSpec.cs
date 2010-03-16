using specr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace specr_tests
{
    
    
    /// <summary>
    ///Describes the expected behaviour and usage of the DynamicBooleanAsserter object that is returned 
    ///when Should().Be() or Should().NotBe() is called
    ///</summary>    
    [TestClass]
    public class DescribeDynamicBooleanAsserter
    {
        private Person person;       
        
        [TestInitialize]
        public void Before()
        {
            person = new Person();
            person.IsAwesome = true;
        }

        [TestMethod]
        public void It_Should_Test_A_Boolean_Starting_With_Is_Is_True_If_Be_Was_Used()
        {
            dynamic dAssert = person.Should().Be();
            dAssert.Awesome();
        }

        [TestMethod]
        public void It_Should_Test_A_Boolean_Starting_With_Is_Is_False_If_NotBe_Was_Used()
        {            
            person.IsAwesome = false;
            person.Should().NotBe().Awesome();            
        }
       
    }
}
