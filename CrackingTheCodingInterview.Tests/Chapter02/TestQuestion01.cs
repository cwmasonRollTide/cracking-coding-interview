using CrackingTheCodingInterview.Chapter02;
using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion01
{
    private static Question01 Sut => new();

    [Fact]
    public void RemoveDuplicates_Case1()
    {
        var head = new Node<int>(10)
        {
            Next = new Node<int>(5)
            {
                Next = new Node<int>(8)
                {
                    Next = new Node<int>(10)
                }
            }
        };
        var expected = new Node<int>(5)
        {
            Next = new Node<int>(8)
            {
                Next = new Node<int>(10)
            }
        };

        var result = (Node<int>)Sut.Run(head);
        result.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void RemoveDuplicates_Case2()
    {
        var head = new Node<int>(10);
        head.Append(5);
        head.Append(8);
        head.Append(10);
        head.Append(7);
        head.Append(4);
        head.Append(7);

        var expected = new Node<int>(5);
        expected.Append(8);
        expected.Append(10);
        expected.Append(4);
        expected.Append(7);


        var result = (Node<int>)Sut.Run(head);
        result.Should().BeEquivalentTo(expected);
    }
}