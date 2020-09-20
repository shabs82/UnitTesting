using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstConditionIfTrue()
        {
            BusFare busfare = new BusFare();
            int km = 80;
            int passengers = 5;

            Assert.IsTrue(busfare.CalculateFare(km , passengers).Equals(386));
        }

        [TestMethod]
        public void TestFirstConditionIfFalse()
        {
            BusFare busFare = new BusFare();
            int km = 80;
            int passengers = 10;
            Assert.IsFalse(busFare.CalculateFare(km, passengers).Equals(250));
        }
    }
}
