using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("deed", true)]
        [InlineData("hello", false)]
        [InlineData("false", false)]
        [InlineData("detartrated", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {

            //Arrange

            var test = new WordSmith();

            //Act

            var actual = test.IsAPalindrome(word);

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
