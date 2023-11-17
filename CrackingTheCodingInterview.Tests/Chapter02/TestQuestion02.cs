using FluentAssertions;
using CrackingTheCodingInterview.Shared;
using CrackingTheCodingInterview.Chapter02;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion02
{
    private static Question02 Sut => new();
    
    [Fact]
    public void RemoveDuplicates_Case1()
    {
        var head = new Node<int>(10);
        head.Append(5);
        head.Append(8);
        head.Append(10);
        head.Append(7); // three up from last
        head.Append(4);
        head.Append(7);
        var k = 3;
        var expected = 7;


        var result = (int)Sut.Run(head, k);
        result.Should().Be(expected);
    }
    
    [Fact]
    public void RemoveDuplicates_Case2()
    {
        var head = new Node<int>(10);
        head.Append(5);
        head.Append(8);
        head.Append(10);
        var k = 2;
        var expected = 8;


        var result = (int)Sut.Run(head, k);
        result.Should().Be(expected);
    }
}