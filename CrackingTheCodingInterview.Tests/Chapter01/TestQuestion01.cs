using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion01
{
    private static Question01 Sut => new();
    
    [Theory]
    [InlineData("abcde", true)]
    [InlineData("hello", false)]
    [InlineData("apple", false)]
    [InlineData("kite", true)]
    [InlineData("padle", true)]
    public void UniqueCharacters(string word, bool expectedResult)
    {
        var result = (bool)Sut.Run(word);
        result.Should().Be(expectedResult);
    }
}