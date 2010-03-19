using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace specr
{
    public static class UnitTestingFramework
    {
        public static void AssertAreEqual<T>(T expected, T obj)
        {
            Assert.AreEqual<T>(expected, obj);
        }

        public static void AssertAreNotEqual<T>(T expected, T obj)
        {
            Assert.AreNotEqual<T>(expected, obj);
        }

        public static void AssertIsInstanceOfType<TExpected>(object obj)
        {
            Assert.IsInstanceOfType(obj, typeof(TExpected));
        }

        public static void IsNotInstanceOfType<TNotExpected>(object obj)
        {
            Assert.IsNotInstanceOfType(obj, typeof(TNotExpected));
        }

        public static void AssertIsNotNull(object obj)
        {
            Assert.IsNotNull(obj);
        }

        public static void AssertIsNull(object obj)
        {
            Assert.IsNull(obj);
        }
    }
}
