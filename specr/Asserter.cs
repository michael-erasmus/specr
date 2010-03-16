
using System.Dynamic;
namespace specr
{
    public class Asserter<T> : DynamicObject
    {
        private T obj;

        public Asserter(T obj)
        {            
            this.obj = obj;
        }

        public void Equal(T expected)
        {
            UnitTestingFramework.AssertAreEqual<T>(expected, obj);
        }

        public void NotEqual(T notExpected)
        {
            UnitTestingFramework.AssertAreNotEqual<T>(notExpected, obj);
        }

        public dynamic Be() 
        { 
            return new DynamicBooleanAsserter<T>(obj, true);
        }

        public dynamic NotBe()
        { 
            return new DynamicBooleanAsserter<T>(obj, false); 
        } 

        public void BeA<TExpected>()
        {
            UnitTestingFramework.AssertIsInstanceOfType<TExpected>(obj);
        }

        public void BeAn<TExpected>()
        {
            BeA<TExpected>();
        }

        public void NotBeA<TNotExpected>()
        {
            UnitTestingFramework.IsNotInstanceOfType<TNotExpected>(obj);
        }

        public void NotBeAn<TNotExpected>()
        {
            NotBeA<TNotExpected>();
        }
    }
}