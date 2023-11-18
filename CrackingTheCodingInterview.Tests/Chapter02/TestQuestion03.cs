using CrackingTheCodingInterview.Chapter02;
using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion03
{
    private static Question03 Sut => new ();

    [Fact]
    public void ShouldDelete_MiddleElement()
    {
        var head = new Node<char>('a');
        head.Append('b');
        head.Append('c');
        head.Append('d');
        head.Append('e');

        var expected = new Node<char>('a');
        expected.Append('b');
        expected.Append('d');
        expected.Append('e');
        
        var result = (Node<char>)Sut.Run(head, 'c')!;
        result.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void ShouldDelete_MiddleElement_ints()
    {
        var head = new Node<int>(1);
        head.Append(2);
        head.Append(3);
        head.Append(4);
        head.Append(5);

        var expected = new Node<int>(1);
        expected.Append(2);
        expected.Append(4);
        expected.Append(5);

        head.Delete(3);
        
        head.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void ShouldDelete_HeadNode()
    {
        var head = new Node<int>(1);
        head.Append(2);
        head.Append(3);
        head.Append(4);
        head.Append(5);

        var expected = new Node<int>(2);
        expected.Append(3);
        expected.Append(4);
        expected.Append(5);

        head.Delete(1);
        
        head.Should().BeEquivalentTo(expected);
    }
}