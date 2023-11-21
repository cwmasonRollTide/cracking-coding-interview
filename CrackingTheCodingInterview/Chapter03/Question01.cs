using System.Dynamic;
using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter03;

/// <summary>
/// Think about a way to implement m stacks in one array
/// </summary>
public class Question01
{
    
    // Going to use arraylist and split into three sections.
    
    // 0 ... stacks.Length / 3 - 1
    
    // stacks.Length / 3 ... 2*stacks.Length / 3 - 1, stacks.Length - 1
    
    // for m number of stacks, n = array size, ... -> (0, n/m -1), (n/m, 2n/m -1, (2n/m, 3n/m -1)
}

public class MultiStack<T> 
{
    private T?[] _values;
    private int _numberOfStacks;
    private int _stackCapacity;

    public MultiStack(int numberOfStacks, int capacity)
    {
        _numberOfStacks = numberOfStacks;
        _stackCapacity = capacity / numberOfStacks;
        _values = new T?[capacity];
    }

    public void Push(int stackNum, T? value)
    {
        if (stackNum < 0 || stackNum >= _numberOfStacks)
            throw new IndexOutOfRangeException();
            
        int index = GetTopIndex(stackNum) + 1;
        if (index >= (stackNum + 1) * _stackCapacity)
            throw new StackOverflowException();

        _values[index] = value;
    }

    public T? Pop(int stackNum)
    {
        if (stackNum < 0 || stackNum >= _numberOfStacks)
            throw new IndexOutOfRangeException();

        int index = GetTopIndex(stackNum);
        if (index < stackNum * _stackCapacity)
            throw new InvalidOperationException();

        T? value = _values[index];
        _values[index] = default;
        return value;
    }

    private int GetTopIndex(int stackNum) 
    {
        int offset = stackNum * _stackCapacity;
        for (int i = offset + _stackCapacity - 1; i >= offset; i--) 
        {
            if (!EqualityComparer<T>.Default.Equals(_values[i], default(T))) 
                return i;
        }
        return -1;
    }
}