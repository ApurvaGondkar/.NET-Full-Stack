using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sample1mstest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 20;
            Assert.IsTrue(a > 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 20;
            Assert.IsNotNull(a);
        }
        [TestMethod]

        public void TestMethod3()
        {
            int a = 20;
            int b = 10;
            Assert.AreNotEqual(a,b);
        }

        [TestMethod]

        public void TestMethod4()
        {
            string a = " Hello world";
            StringAssert.Contains(a, "Hello");
           
        }
    }
}
