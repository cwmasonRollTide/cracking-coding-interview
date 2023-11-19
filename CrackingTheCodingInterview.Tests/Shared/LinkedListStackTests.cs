using CrackingTheCodingInterview.Shared;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Shared;

public class LinkedListStackTests
{
    [Fact]
    public void Should_Push_And_Pop_From_Stack()
    {
        var stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(200);
        stack.Push(1000);

        var result = stack.Pop();
        result.Should().Be(1000);
    }
    
    [Fact]
    public void Should_Push_And_Pop_From_Stack_Strings_LIFO()
    {
        var stack = new LinkedListStack<string>();
        stack.Push("Lions");
        stack.Push("Zebras");
        stack.Push("Bears");

        stack.Pop().Should().Be("Bears");
        stack.Pop().Should().Be("Zebras");
        stack.Pop().Should().Be("Lions");
    }
}