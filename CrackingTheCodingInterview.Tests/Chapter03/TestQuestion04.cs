﻿using CrackingTheCodingInterview.Chapter03;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter03;

public class TestQuestion04
{
	[Fact]
	public void Should_Add_And_Remove_Elements_Of_Queue_InitializedVersion()
	{
		const int firstIn = 1;
		var queue = new MyQueue<int>();
		queue.Add(firstIn);
		queue.Add(5);
		queue.Add(6);
		queue.Add(7);

		int removedValue = queue.Remove();
		firstIn.Should().Be(removedValue);
	}

	[Fact]
	public void Should_Maintain_Fifo_Order_Strings()
	{
		const string firstIn = "This is the first string";
		const string secondIn = "This is the second";
		const string thirdIn = "This is the third entry";
		const string fourthIn = "this is the fourth time typing this shit";

		var queue = new MyQueue<string>();
		queue.Add(firstIn);
		queue.Add(secondIn);
		queue.Add(thirdIn);
		queue.Add(fourthIn);

		queue.Remove().Should().BeEquivalentTo(firstIn);
		queue.Remove().Should().BeEquivalentTo(secondIn);
		queue.Remove().Should().BeEquivalentTo(thirdIn);
		queue.Remove().Should().BeEquivalentTo(fourthIn);
	}
}