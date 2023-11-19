using CrackingTheCodingInterview.Chapter02;
using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion08
{
    private static Question08 Sut => new();

    [Fact]
    public void ShouldDetectLoopedList()
    {
        var head = new Node<int>(10);
        head.Append(2);
        head.Append(5);
        head.Append(11);
        var circularNode = new Node<int>(25);
        head.Next.Next.Next.Next = circularNode;
        head.Append(200);
        head.Next.Next.Next.Next.Next.Next = circularNode;

        var result = (Node<int>)Sut.Run(head)!;
        result.Should().BeEquivalentTo(circularNode);
    }

    [Fact]
    public void ShouldThrowException_IfNoCircularReference()
    {
        var head = new Node<int>(10);
        head.Append(2);
        head.Append(11);

        Assert.Throws<Exception>(() => Sut.Run(head));
    }
}