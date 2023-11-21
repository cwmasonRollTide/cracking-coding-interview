namespace CrackingTheCodingInterview.Shared;

public class LinkedListQueue<T>
{
    private Node<T>? Start;
    private Node<T>? End;

    public LinkedListQueue()
    {
        Start = null;
        End = null;
    }

    public void Add(T data)
    {
        var newNode = new Node<T>(data);
        if (Start == null)
        {
            Start = newNode;
            End = newNode;
        }
        else
        {
            End!.Next = newNode;
            End = newNode;
        }
    }
    
    public T? Remove()
    {
        if (Start == null) return default;
        
        T toReturn = Start.Data!;
        Start = Start.Next;

        if (Start == null)
        {
            End = null;
        }

        return toReturn;
    }

    public T? Peek()
    {
        return Start == null ? throw new ArgumentOutOfRangeException() : Start.Data;
    }

    public bool IsEmpty()
    {
        return Start == null;
    }
}