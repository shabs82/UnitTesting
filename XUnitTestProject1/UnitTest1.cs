using System;
using UnitTesting1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData( 80, 5 , 386)]
        [InlineData(300, 10, 955)]
        [InlineData( 0, 0 , 130)]
        [InlineData(200, 15, 730)]
        [InlineData(510, 0, 1147.5)]
        public void TestAllConditions(int km , int passengers , double expectedResult)
        {
            BusFare busFare = new BusFare();
            double actualResult =busFare.CalculateFare(km , passengers);
            Assert.Equal(expectedResult, actualResult);

        }


    }
}
