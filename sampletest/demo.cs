using Assignment_4ExceptionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sampletest
{
    [TestClass] 
    public class demo
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new MyStack();
            Assert.IsFalse(a.car);

        }
    }
}
