using CrackingTheCodingInterview.Chapter03;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter03;

public class TestQuestion02
{
	[Fact]
	public void MinStack_Should_ReturnMin()
	{
		var minimum = -1000;
		var stack = new MinStack<int>();
		stack.Push(5);
		stack.Push(minimum);
		stack.Push(100);

		var result = stack.Min();
		result.Should().Be(minimum);
	}

	[Fact]
	public void MinStack_Should_LIFO()
	{
		var stack = new MinStack<int>();
		const int firstIn = 20;
		const int secondIn = 102;
		const int thirdIn = -12;
		const int fourthIn = 200;
		stack.Push(firstIn);
		stack.Push(secondIn);
		stack.Push(thirdIn);
		stack.Push(fourthIn);
		stack.Pop().Should().Be(fourthIn);
		stack.Pop().Should().Be(thirdIn);
		stack.Pop().Should().Be(secondIn);
		stack.Pop().Should().Be(firstIn);
		stack.Min().Should().Be(thirdIn);
	}
}