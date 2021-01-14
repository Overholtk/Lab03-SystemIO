using System;
using Xunit;
using ReviewC;


namespace LAB03TEST
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData(new int[4] { 1, 800, 65, 27 }, 800)]
        [InlineData(new int[4] { -1, -800, -65, -27 }, -1)]
        [InlineData(new int[4] { 800, 800, 800, 800 }, 800)]
        public void TestChallenge5(int[] arr, int output)
        {
            Assert.Equal(output, SystemIOPractice.ChallengeFive(arr));
        }

    }
}
