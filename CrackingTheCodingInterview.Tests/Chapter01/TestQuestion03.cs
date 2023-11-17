using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion03
{
    private static Question03 Sut => new();
    
    [Theory]
    [InlineData("Mr John Smith     ", 13, "Mr%20John%20Smith")]
    [InlineData("Mr Connor Mason     ", 15, "Mr%20Connor%20Mason")]
    [InlineData("Another Test Case     ", 17, "Another%20Test%20Case")]
    public void UrlifyWord(string phrase, int trueLength, string expectedResult)
    {
        var result = (string)Sut.Run(phrase, trueLength);
        result.Should().Be(expectedResult);
    }
}