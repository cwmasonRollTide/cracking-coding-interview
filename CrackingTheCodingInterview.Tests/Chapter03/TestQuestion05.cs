using CrackingTheCodingInterview.Chapter03;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter03;

public class TestQuestion05
{
	private static Question05 Sut => new ();
	
	[Fact]
	public void Should_Sort_StackItems()
	{
		const int middleTwo = 56;
		const int max = 100;
		const int min = -1;
		const int middleOne = 24;
		var stack = new Stack<int>();
		stack.Push(middleTwo);
		stack.Push(max);
		stack.Push(min);
		stack.Push(middleOne);
		var result = (Stack<int>)Sut.Run(stack)!;
		result.Pop().Should().Be(min);
		result.Pop().Should().Be(middleOne);
		result.Pop().Should().Be(middleTwo);
		result.Pop().Should().Be(max);
	}
}