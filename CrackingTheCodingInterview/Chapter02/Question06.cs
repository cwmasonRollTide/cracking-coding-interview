using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

/// <summary>
/// Determine if a linked list is a palindrome
/// </summary>
public class Question06 : Question
{
    /// <summary>
    /// Reverse the linkedlist and convert to a string at the same time
    /// construct a string from the linkedlist going forwards as well
    /// Compare the reversed vs normal order and if they are equal, palindrome
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private static bool IsPalindrome(Node<int> input)
    {
        string reversed = ReverseListIntoString(input);
        string forward = ExtractForwardNumber(input);
        return reversed.Equals(forward);
    }
    
    private static string ReverseListIntoString(Node<int> node)
    {
        if (node.Next == null)
        {
            return node.Data.ToString();
        }
        return ReverseListIntoString(node.Next) + node.Data;
    }

    private static string ExtractForwardNumber(Node<int> node)
    {
        if (node.Next == null)
        {
            return node.Data.ToString();
        }
        return node.Data + ExtractForwardNumber(node.Next);
    }
    
    public override object? Run(params object[] parameters)
    {
        var input = parameters[0] as Node<int>;
        return IsPalindrome(input!);
    }
}