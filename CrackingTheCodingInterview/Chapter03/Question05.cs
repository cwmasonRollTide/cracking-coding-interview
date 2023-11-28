using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter03;

/// <summary>
/// Write a program to sort a stack such that the smallest items are on the top.
/// You can use an additional temp stack but not any other data structure
/// </summary>
public class Question05 : Question
{
	private Stack<int>? SortStack(Stack<int> startStack)
	{
		var tmpStack = new Stack<int>();
		while (startStack.Count > 0)
		{
			int temp = startStack.Pop();
			while (tmpStack.Count > 0 && temp < tmpStack.Peek())
			{
				startStack.Push(tmpStack.Pop());
			}
			tmpStack.Push(temp);
		}

		while (tmpStack.Count > 0)
		{
			startStack.Push(tmpStack.Pop());
		}

		return startStack;
	}
	
	public override object? Run(params object[] parameters)
	{
		var startingStack = parameters[0] as Stack<int>;
		return SortStack(startingStack);
	}
}