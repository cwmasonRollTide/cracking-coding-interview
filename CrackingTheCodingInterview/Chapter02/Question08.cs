using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

public class Question08 : Question
{
    private static Node<int> FindCircularNode(Node<int> input)
    {
        var foundElements = new HashSet<Node<int>>();
        Node<int>? iterator = input;
        while (iterator != null)
        {
            if (foundElements.Contains(iterator)) return iterator;
            
            foundElements.Add(iterator);
            iterator = iterator.Next;
        }

        throw new Exception("Circular reference not found");
    }
    public override object? Run(params object[] parameters)
    {
        var input = parameters[0] as Node<int>;
        return FindCircularNode(input!);
    }
}