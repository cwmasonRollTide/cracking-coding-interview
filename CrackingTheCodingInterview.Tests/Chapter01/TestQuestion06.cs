using CrackingTheCodingInterview.Chapter01;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion06
{
    private static Question06 Sut => new();

    [Theory]
    [InlineData("aabbbcdddde", "a2b3c1d4e1")]
    [InlineData("aaaaaaaabbbiiilllllllll", "a8b3i3l9")]
    [InlineData("abcd", "abcd")]
    [InlineData("connorzzzzzzzzzzzz", "c1o1n2o1r1z12")]
    public void Compress(string input, string expectedOutput)
    {
        var result = (string)Sut.Run(input);
        result.Should().Be(expectedOutput);
    }
}