using CrackingTheCodingInterview.Chapter02;
using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion06
{
    private static Question06 Sut => new();

    [Fact]
    public void Should_Ascertain_LinkedList_Palindromes()
    {
        var node = new Node<int>(5);
        node.Append(2);
        node.Append(5);

        var result = (bool)Sut.Run(node)!;
        result.Should().BeTrue();
    }
    
    [Fact]
    public void Should_Detect_LinkedList_NotPalindromes()
    {
        var node = new Node<int>(5);
        node.Append(2);
        node.Append(5);
        node.Append(6);

        var result = (bool)Sut.Run(node)!;
        result.Should().BeFalse();
    }
}