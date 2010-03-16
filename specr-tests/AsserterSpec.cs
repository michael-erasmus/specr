using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
#if NUNIT
using NUnit.Framework;  
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif
using specr;

namespace specr_tests
{
    /// <summary>
    /// Describes the Asserter object that is return from the Should() method
    /// </summary>
#if NUNIT
    [TestFixture]
#else
    [TestClass]
#endif
    public class DescribeAsserter
    {
        private Asserter<string> fooAsserter;
        private Person person;
        private Asserter<Person> personAsserter;        

#if NUNIT
        [SetUp]
#else
        [TestInitialize]
#endif
        public void Before() 
        {
            var name = "foo";
            fooAsserter = name.Should();
            person = new Person();
            personAsserter = person.Should();
        }
#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Be_Able_To_Test_For_Equality_With_The_Equal_Method()
        {
            fooAsserter.Equal("foo");
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Be_Able_To_Test_For_InEquality_With_The_NotEqual_Method()
        {
            fooAsserter.NotEqual("bar");
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Return_A_DynamicBooleanAsserter_That_Expects_True_When_Be_Is_Called()
        {
            var assert = personAsserter.Be() as DynamicBooleanAsserter<Person>;

            assert.Should().BeA<DynamicBooleanAsserter<Person>>();
            assert.Expected.Should().Equal(true);
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Return_A_DynamicBooleanAsserter_That_Expects_False_When_NotBe_Is_Called()
        {
            var assert = personAsserter.NotBe() as DynamicBooleanAsserter<Person>;

            assert.Should().BeA<DynamicBooleanAsserter<Person>>();
            assert.Expected.Should().Equal(false);
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Be_Able_To_Check_A_Objects_Type_With_BeA()
        {
            fooAsserter.BeA<string>();
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Have_A_BeAn_Method_That_Is_A_Synonym_For_BeA()
        {
            fooAsserter.BeAn<string>();
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Be_Able_To_Check_A_Objects_Is_Not_A_Type_With_NotBeA()
        {
            fooAsserter.NotBeA<int>();
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Have_A_NotBeAn_Method_That_Is_A_Synonym_For_NotBeA()
        {
            fooAsserter.NotBeAn<int>();
        }

#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Return_A_DynamicNullMemberAsserter_Expecting_NonNull_When_HaveA_Is_Called()
        {
            var assert = personAsserter.HaveA() as DynamicNullMemberAsserter<Person>;
            assert.Expected.Should().Equal(ExpectedNullability.NotNull);
        }

        
#if NUNIT
        [Test]
#else
        [TestMethod]
#endif
        public void It_Should_Return_A_DynamicNullMemberAsserter_Expecting_Null_When_NotHaveA_Is_Called()
        {
            var assert = personAsserter.NotHaveA() as DynamicNullMemberAsserter<Person>;
            assert.Expected.Should().Equal(ExpectedNullability.Null);
        }
    }
}
