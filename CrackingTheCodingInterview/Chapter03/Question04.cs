namespace CrackingTheCodingInterview.Chapter03;

public class Question04
{
	
}

public class MyQueue<T>
{
	private readonly Stack<T> _primary = new();
	private readonly Stack<T> _secondary = new();

	public void Add(T data)
	{
		_primary.Push(data);
	}

	public T Remove()
	{
		while (_primary.Count > 0)
		{
			_secondary.Push(_primary.Pop());
		}

		var toReturn = _secondary.Pop();
		while (_secondary.Count > 0)
		{
			_primary.Push(_secondary.Pop());
		}

		return toReturn;
	}
}