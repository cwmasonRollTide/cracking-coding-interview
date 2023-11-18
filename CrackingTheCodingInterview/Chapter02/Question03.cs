using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

/// <summary>
/// Implement code to delete element in the middle of a list, not head or tail necessary
/// </summary>
public class Question03 : Question
{
    private static Node<char>? DeleteElement(Node<char>? head, char? data)
    {
        Node<char>? current = head;
        while (current?.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                break; // No need to keep iterating, we found and deleted it
            }
            current = current.Next;
        }
        return head;
    }
    
    public override object? Run(params object[] parameters)
    {
        var head = parameters[0] as Node<char>;
        char toDelete = parameters[1] as char? ?? '1';
        return DeleteElement(head!, toDelete);
    }
}