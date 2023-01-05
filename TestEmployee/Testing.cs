using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Assignment_3;
namespace TestEmployee
{
    [TestClass]
    public class testing
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Employee();
            Assert.IsNull(a.Empno);

        }
    }
}
