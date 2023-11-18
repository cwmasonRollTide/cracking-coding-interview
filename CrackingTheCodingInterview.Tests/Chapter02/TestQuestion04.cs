using CrackingTheCodingInterview.Chapter02;
using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion04
{
    private static Question04 Sut => new();

    [Fact]
    public void ShouldPartitionList()
    {
        var head = new Node<int>(3);
        head.Append(5);
        head.Append(8);
        head.Append(5);
        head.Append(10);
        head.Append(2);
        head.Append(1);
        
        var expected = new Node<int>(3);
        expected.Append(2);
        expected.Append(1);
        expected.Append(5);
        expected.Append(8);
        expected.Append(5);
        expected.Append(10);

        var result = (Node<int>)Sut.Run(head, 5)!;
        result.Should().BeEquivalentTo(expected);
    }
}