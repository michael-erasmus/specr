using specr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace specr_specs
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

        [TestMethod]
        public void Should_Call_The_IsNull_Extension_Method_When_Null_Is_Called_As_A_Special_Case()
        {
            person.Should().NotBe().Null();
            person = null;
            person.Should().Be().Null();
        }
       
    }
}
