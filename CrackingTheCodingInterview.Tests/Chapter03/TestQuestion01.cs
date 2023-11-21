using CrackingTheCodingInterview.Chapter03;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter03;

public class TestQuestion01
{
    [Fact]
    public void MultiStack_Implementation_ShouldThrow_OverflowException()
    {
        const int numberOfStacks = 3;

        var stacks = new MultiStack<int>(numberOfStacks, 9);
        stacks.Push(0, 200);
        stacks.Push(0, 300);
        stacks.Push(0, 400);
        Assert.Throws<StackOverflowException>(() => stacks.Push(0, 500));
    }
    
    [Fact]
    public void MultiStack_Implementation_ShouldWorkAsStack()
    {
        const int numberOfStacks = 3;
        const int firstIn = 200;
        const int secondIn = 300;
        const int thirdIn = 400;

        var stacks = new MultiStack<int>(numberOfStacks, 9);
        stacks.Push(0, firstIn);
        stacks.Push(0, secondIn);
        stacks.Push(0, thirdIn);
        stacks.Pop(0).Should().Be(thirdIn);
        stacks.Pop(0).Should().Be(secondIn);
        stacks.Pop(0).Should().Be(firstIn);
    }
}