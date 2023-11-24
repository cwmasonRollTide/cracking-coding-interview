using System.Collections;
using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter03;

/// <summary>
/// Stack of plates: Imagine a stack of plates. If the stack gets too high
/// it might topple. Therefore, in real life, we would likely start a new stack
/// when the previous stack exceeds some threshold. Implement a data structure
/// SetOfStacks that mimics this. SetofStacks should be composed of several stacks
/// and should create a new stack once the previous one exceeds capacity.
/// SetOfStacks.push() and SetofStacks.pop should behave identically toa single stack
///
/// Follow up: implement a function popAt(int index) which performs a pop operation on a specific sub stack
/// </summary>
public class Question03
{
	
}

public class StackOfPlates<T>
{
	private readonly int? _capacity;
	private int _numberOfStack = 0;
	private List<Stack<T>> _stacks = new()
	{
		new Stack<T>()
	};

	public StackOfPlates(int cap)
	{
		_capacity = cap;
	}

	public void Push(T data)
	{
		if (_stacks.ElementAt(_numberOfStack).Count == _capacity)
		{
			var newStack = new Stack<T>();
			newStack.Push(data);
			_stacks.Add(newStack);
			_numberOfStack++;
			return;
		}
		
		_stacks.ElementAt(_numberOfStack).Push(data);
	}

	public T Pop()
	{
		var toReturn = _stacks.ElementAt(_numberOfStack).Pop();
		if (_stacks.ElementAt(_numberOfStack).Count == 0)
		{
			_stacks.RemoveAt(_numberOfStack);
			_numberOfStack--;
		}
		return toReturn;
	}

	public T PopAt(int index)
	{
		var toReturn = _stacks.ElementAt(index).Pop();
		if (_stacks.ElementAt(index).Count == 0)
		{
			_stacks.RemoveAt(index);
		}

		return toReturn;
	}
}