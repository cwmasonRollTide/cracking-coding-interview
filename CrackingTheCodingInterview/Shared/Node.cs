namespace CrackingTheCodingInterview.Shared;

public class Node<T>
{
    public T? Data;
    public Node<T>? Next;

    public Node(T? data)
    {
        Data = data;
    }

    public bool Contains(T data)
    {
        Node<T>? iterator = this;
        if (iterator.Data?.Equals(data) ?? false) return true;

        while (iterator.Next != null)
        {
            iterator = iterator.Next;
            if (iterator.Data?.Equals(data) ?? false) return true;
        }

        return false; 
    }

    public void Append(T data)
    {
        var end = new Node<T>(data);
        Node<T> iterator = this;
        while (iterator.Next != null)
        {
            iterator = iterator.Next;
        }
        iterator.Next = end;
    }

    public void Delete(T data)
    {
        // Handling the head node
        if (Data?.Equals(data) ?? false)
        {
            if (Next == null)
            {
                return;
            }
            
            Data = Next.Data;
            Next = Next.Next;
            return; // Delete head
        }

        Node<T>? current = this;
        while (current?.Next != null)
        {
            if (current.Next?.Data?.Equals(data) ?? false)
            {
                current.Next = current.Next.Next;
                break; // Data found and removed, exit loop
            }
            current = current.Next;
        }
    }

}