using IsTeenager;

using System;
using Xunit;


namespace IsTennagerTestCode
{
    public class IsTeenagerTestCodeXunit
    {
        [Theory]
        [InlineData( 13 , true)]
        [InlineData(11, false)]
        public void CheckIfTeenager(DateTime birthday , bool expectedResult)
        {
            int yearDifference = DateTime.Now.Year - birthday.Year;
            IsTeenager.IsTeenager isTeen = new IsTeenager.IsTeenager();
            bool actualResult = isTeen.GetAge(birthday);
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
