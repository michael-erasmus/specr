using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace specr
{
    class UnitTestingFramework
    {
        public static void AssertAreEqual<T>(T expected, T obj)
        {
            Assert.AreEqual(expected, obj);
        }

        public static void AssertAreNotEqual<T>(T expected, T obj)
        {
            Assert.AreNotEqual(expected, obj);
        }

        public static void AssertIsInstanceOfType<TExpected>(object obj)
        {            
            Assert.IsInstanceOf<TExpected>(obj);
        }

        public static void IsNotInstanceOfType<TNotExpected>(object obj)
        {
            Assert.IsNotInstanceOf<TNotExpected>(obj);
        }

        public static void AssertIsNull(object obj)
        {
            Assert.IsNull(obj);
        }

        public static void AssertIsNotNull(object obj)
        {
            Assert.IsNotNull(obj);
        }
    }
}
