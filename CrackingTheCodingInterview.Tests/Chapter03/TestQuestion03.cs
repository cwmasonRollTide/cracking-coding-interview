using CrackingTheCodingInterview.Chapter03;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter03;

public class TestQuestion03
{
	[Fact]
	public void StackOfPlates_ShouldBehave_LikeStack()
	{
		var stack = new StackOfPlates<int>(3);
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
	}
	
	[Fact]
	public void StackOfPlates_ShouldRemove_FromSpecific_Stack()
	{
		var stack = new StackOfPlates<int>(2);
		const int firstIn = 20;
		const int secondIn = 102;
		const int thirdIn = -12;
		const int fourthIn = 200;
		stack.Push(firstIn);
		stack.Push(secondIn);
		stack.Push(thirdIn);
		stack.Push(fourthIn);
		stack.PopAt(1).Should().Be(fourthIn);
	}
}