using System;
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
            // a) create objects
            BusFare busfare = new BusFare();

            //b) set up
            int km = 80;
            int passengers = 5;
            bool expectedResult = true;
            //c) act
            bool actualresult = busfare.CalculateFare(km, passengers).Equals(386);
            //d) assert
            Assert.AreEqual(expectedResult , actualresult);

            //Assert.IsTrue(busfare.CalculateFare(km , passengers).Equals(386));
        }

        [TestMethod]
        public void TestFirstConditionIfFalse()
        {
            BusFare busFare = new BusFare();
            int km = 80;
            int passengers = 10;
            Assert.IsFalse(busFare.CalculateFare(km, passengers).Equals(250));
        }

        [TestMethod]
        public void TestFirstConditionExceptions()
        {
            BusFare busfare = new BusFare();
            int km = -110;
            int passengers = -5;


            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>busfare.CalculateFare(km, passengers));
        }
    }
}
