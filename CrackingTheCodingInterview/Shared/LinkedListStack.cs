namespace CrackingTheCodingInterview.Shared;

public class LinkedListStack<T>
{
    private Node<T>? Top;

    public LinkedListStack(T data)
    {
        Top = new Node<T>(data);
    }
    
    public LinkedListStack()
    {
        Top = null;
    }
    
    public void Push(T data)
    {
        if (Top == null)
        {
            Top = new Node<T>(data);
            return;
        }
        var newNode = new Node<T>(data);
        Node<T>? oldTop = Top;
        Top = newNode;
        Top.Next = oldTop;
    }

    public T? Pop()
    {
        if (Top == null) throw new ArgumentOutOfRangeException();
        T? toReturn = Top.Data;
        Top = Top.Next;
        return toReturn;
    }

    public T? Peek() => Top != null ? Top.Data : default;

    public bool IsEmpty() => Top == null;
}