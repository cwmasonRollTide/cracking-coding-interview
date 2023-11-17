using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion05
{
    private static Question05 Sut => new();

    [Theory]
    [InlineData("pale", "ple", true)]
    [InlineData("pale", "bale", true)]
    [InlineData("pale", "bae", false)]
    [InlineData("pales", "pale", true)]
    [InlineData("connor", "no", false)]
    public void IsOneEditOrLessAway(string wordOne, string wordTwo, bool expectedResult)
    {
        var result = (bool)Sut.Run(wordOne, wordTwo);
        result.Should().Be(expectedResult);
    }
}