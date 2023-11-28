using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter03;

/// <summary>
/// How would you design a stack which in addition to push and pop,
/// has a function min which returns the minimum element? Push, Pop,
/// and min should all operate in O(1)
/// </summary>
public class Question02
{
    
}

public class MinStack<T>
{
	private T? _min;
	private Node<T>? _top;

	public void Push(T data)
	{
		var newNode = new Node<T>(data);
		if (_top == null)
		{
			_top = newNode;
			_min = data;
			return;
		}
		var oldTop = _top;
		_top = newNode;
		_top.Next = oldTop;

		if (Comparer<T>.Default.Compare(data, _min) < 0)
			_min = data;
	}

	public T? Pop()
	{
		if (_top == null) throw new IndexOutOfRangeException();

		var toReturn = _top.Data;
		_top = _top.Next;
		return toReturn;
	}

	public T? Min()
	{
		return _min;
	}
}