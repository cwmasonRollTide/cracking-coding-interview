using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion04
{
    private static Question04 Sut => new();
    
    [Theory]
    [InlineData("Tact Coa", true)]
    [InlineData("randomword", false)]
    [InlineData("leggel", true)]
    [InlineData("leggel two", false)]
    public void IsPalindrome(string word, bool expectedResult)
    {
        var result = (bool)Sut.Run(word);
        result.Should().Be(expectedResult);
    }
}