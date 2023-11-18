using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

/// <summary>
/// Supposed to find the kth element from the last node. Gonna be recursive bout it
/// </summary>
public class Question02 : Question
{
    private static int FindKthFromLastElement(Node<int>? node, int k, ref int i)
    {
        if (node?.Next == null)
        {
            i = 1; // Start counting from the last node
            return node!.Data;
        }

        int data = FindKthFromLastElement(node.Next, k, ref i);
        i += 1; // Increment the count as we return back up the stack

        return i == k ? 
            node.Data : // Found the kth element from last
            data;
    }

    public override object? Run(params object[] parameters)
    {
        var input = parameters[0] as Node<int>;
        int k = parameters[1] as int? ?? 0;
        int index = 0;
        return FindKthFromLastElement(input!, k, ref index);
    }

}