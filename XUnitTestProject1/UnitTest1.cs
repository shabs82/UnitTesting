using System;
using UnitTesting1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( 80, 5 , 386)]
        [InlineData(101, 0, 453.2)]
        [InlineData( 0, 0 , 130)]
        public void TestFirstConditionIfTrue(int km , int passengers , double expectedResult)
        {
            BusFare busFare = new BusFare();
            double actualResult =busFare.CalculateFare(km , passengers);
            Assert.Equal(expectedResult, actualResult);

        }


    }
}
