using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion02
{
    private static Question02 Sut => new();

    [Theory]
    [InlineData("abcde", "edcba", true)]
    [InlineData("deer", "reed", true)]
    [InlineData("xxyyzz", "yyyyyy", false)]
    [InlineData("zzyyi", "yyizz", true)]
    [InlineData("poiejfi", "ipoiejf", true)]
    [InlineData("zzzzzzzzzzzz", "zzzz", false)]
    public void IsPermutation(string wordOne, string wordTwo, bool expectedResult)
    {
        var result = (bool)Sut.Run(wordOne, wordTwo);
        result.Should().Be(expectedResult);
    }
}