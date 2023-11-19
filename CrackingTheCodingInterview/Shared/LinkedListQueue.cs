namespace CrackingTheCodingInterview.Shared;

public class LinkedListQueue<T>
{
    private Node<T>? Start;

    public LinkedListQueue(T data)
    {
        var newNode = new Node<T>(data);
        Start = newNode;
    }

    public LinkedListQueue()
    {
        Start = null;
    }

    public void Add(T data)
    {
        if (Start == null)
        {
            Start = new Node<T>(data);
            return;
        }
        Node<T>? iterator = Start;
        while (iterator.Next != null)
        {
            iterator = iterator.Next;
        }
        iterator.Next = new Node<T>(data);
    }
    
    public T? Remove()
    {
        if (Start == null) return default;
        
        T? toReturn = Start.Data;
        Start = Start.Next;
        return toReturn;
    }
    //peek
    //IsEmpty
}