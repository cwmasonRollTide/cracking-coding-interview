using CrackingTheCodingInterview.Chapter02;
using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion07
{
    private static Question07 Sut => new();

    [Fact]
    public void DetectIntersection()
    {
        var nodeOne = new Node<int>(3);
        nodeOne.Append(4);
        nodeOne.Append(8); // Intersection point
        nodeOne.Append(10);
        nodeOne.Append(11);
        Node<int>? sharedNode = null;
        Node<int> iterator = nodeOne;
        for (var i = 0; i < 3; i++)
        {
            sharedNode = iterator;
            iterator = iterator?.Next!;
        }
        var nodeTwo = new Node<int>(20);
        nodeTwo.Next = new Node<int>(15);
        nodeTwo.Next.Next = sharedNode;

        var result = (Node<int>)Sut.Run(nodeOne, nodeTwo)!;
        
        result.Should().BeEquivalentTo(sharedNode);
    }
    
    [Fact]
    public void ShouldThrowException_IfNoIntersection()
    {
        var head = new Node<int>(10);
        head.Append(2);
        head.Append(11);
        
        var nodeTwo = new Node<int>(20);
        nodeTwo.Next = new Node<int>(15);

        Assert.Throws<Exception>(() => Sut.Run(head, nodeTwo));
    }
}