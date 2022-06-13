using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task0;

namespace TestTask0
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cal1 = new Calculator();
            Assert.AreEqual(cal1.add(1, 2), 3);

        }
        public void TestMethod2()
        {
            var cal2 = new Calculator();
            Assert.AreEqual(cal2.substract(3, 2), 1);

        }
        public void TestMethod3()
        {
            var cal3 = new Calculator();
            Assert.AreEqual(cal3.multiply(1, 2), 2);

        }
        public void TestMethod4()
        {
            var cal4 = new Calculator();
            Assert.AreEqual(cal4.division(2, 1), 2);

        }
    }
}