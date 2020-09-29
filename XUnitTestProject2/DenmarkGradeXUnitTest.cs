using Assignment2Testing;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class DenmarkGradeXUnitTest
    {
        [Theory]
        [InlineData(0 , -3)]
        [InlineData(43, 0)]
        [InlineData(57, 2)]
        [InlineData(67, 4)]
        [InlineData(84, 7)]
        [InlineData(85, 10)]
        [InlineData(98, 12)]
        public void TestGradeConversion(int percentage , double expectedResult)
        {
            DenmarkGradeSystem dkp = new DenmarkGradeSystem();
            double actualResult = dkp.ToGrade(percentage);
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
