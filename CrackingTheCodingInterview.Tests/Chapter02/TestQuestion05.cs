using FluentAssertions;
using CrackingTheCodingInterview.Shared;
using CrackingTheCodingInterview.Chapter02;

namespace CrackingTheCodingInterview.Tests.Chapter02;

public class TestQuestion05
{
    private static Question05 Sut => new ();

    [Fact]
    public void Should_Add_NumbersFromLinkedList_ReverseOrder()
    {
        var firstOperand = new Node<int>(7);
        firstOperand.Append(1);
        firstOperand.Append(6);
        
        var secondOperand = new Node<int>(5);
        secondOperand.Append(9);
        secondOperand.Append(2);

        var expected = new Node<int>(2);
        expected.Append(1);
        expected.Append(9);

        var result = (Node<int>)Sut.Run(firstOperand, secondOperand)!;
        result.Should().BeEquivalentTo(expected);
    }
}