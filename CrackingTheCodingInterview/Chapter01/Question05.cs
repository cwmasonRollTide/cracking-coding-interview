using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// There are three types of edits that can be performed on strings:
/// insert a character, remove a character, or replace a character.
/// Given two strings, write a function to check if they are one edit (or zero edits) away
/// </summary>
public class Question05 : Question
{
    private static bool IsOneEditOrLessAway(string wordOne, string wordTwo)
    {
        if (wordOne.Equals(wordTwo)) return true;
        if (Math.Abs(wordOne.Length - wordTwo.Length) > 1) return false;
        
        // Indexes to move across shorter and longer strings.
        // Strings will only be one character lengthwise apart
        var index1 = 0;
        var index2 = 0;
        var foundDifference = false;
        string shorterString = wordOne.Length < wordTwo.Length ? wordOne : wordTwo;
        string longerString = wordOne.Length < wordTwo.Length ? wordTwo : wordOne;
        
        // Stay within the bounds of both strings
        while (index1 < shorterString.Length && index2 < longerString.Length)
        {
            // Found a difference here. 
            if (shorterString[index1] != longerString[index2])
            {
                // If we had already found a difference, then this is second and > one edit
                if (foundDifference) 
                    return false;
                
                // Flip the bool to true for the check above on next iteration
                foundDifference = true;
                
                // If they are the same length and there is a difference, this is a replace.
                // move shorter string index up one
                if (shorterString.Length == longerString.Length) 
                    index1++;
            }
            else
            {
                // If they are equal at this index, move up shorter string index
                index1++;
            }

            // Always iterate larger string index
            index2++;
        }
        return true;
    }

    public override object Run(params object[] parameters)
    {
        var wordOne = parameters[0] as string;
        var wordTwo = parameters[1] as string;
        return IsOneEditOrLessAway(wordOne!, wordTwo!);
    }
}