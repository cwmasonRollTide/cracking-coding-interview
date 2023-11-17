using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Implement an algorithm to determine if a string has all unique characters.
/// What if you cannot use additional data structures?
/// </summary>
public class Question01 : Question
{
    private static bool IsUniqueChars(string word)
    {
        var wordSet = new HashSet<char>();
        foreach (char c in word.ToList())
        {
            if (wordSet.Contains(c)) return false;
            wordSet.Add(c);
        }
        return true;
    }
    
    public override object Run(params object[] parameters)
    {
        return IsUniqueChars(parameters[0] as string ?? throw new InvalidOperationException());
    }
}