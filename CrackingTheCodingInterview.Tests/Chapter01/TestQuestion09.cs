using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion09
{
    private static Question09 Sut => new();

    [Theory]
    [InlineData("rats", "atsr", true)]
    [InlineData("connor", "anna", false)]
    [InlineData("connor", "roxxoc", false)]
    [InlineData("waterbottle", "erbottlewat", true)]
    public void RotationOfStrings(string wordOne, string wordTwo, bool expectedResult)
    {
        var result = (bool)Sut.Run(wordOne, wordTwo);
        result.Should().Be(expectedResult);
    }
}