using Microsoft.VisualStudio.TestTools.UnitTesting;
using TESTLINQ;

namespace CalculationTests
{
    [TestClass]
    public class CalTests
    {
        [TestMethod]
        public void TestSum()
        {
            //Arrange
            int x = 100;
            int y = 200;
            int expected = 300;

            Calculation cal = new Calculation();
            
            //Act            
            int actual = cal.SUM(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
