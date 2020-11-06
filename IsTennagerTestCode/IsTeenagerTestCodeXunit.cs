using IsTeenager;

using System;
using Xunit;


namespace IsTennagerTestCode
{
    public class IsTeenagerTestCodeXunit
    {
        [Theory]
        [InlineData( "Oct 10 , 2005" , true)]
        [InlineData("Jan 5 , 2014", false)]
        public void CheckIfTeenager(String birthday , bool expectedResult)
        {
            var parsedDate = DateTime.Parse(birthday);
            int yearDifference = DateTime.Now.Year - parsedDate.Year;
            IsTeenager.IsTeenager isTeen = new IsTeenager.IsTeenager();
            bool actualResult = isTeen.GetAge(parsedDate);
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
