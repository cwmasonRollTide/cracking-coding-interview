using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Given two strings, write code to check if the second word is a rotation of the first one
/// e.g. waterbottle has a rotation of erbottlewat
/// </summary>
public class Question09 : Question
{
    private static bool IsRotation(string wordOne, string wordTwo)
    {
        if (wordOne.Length != wordTwo.Length) return false;

        string concatenated = wordOne + wordOne;
        return concatenated!.Contains(wordTwo);
    }
    public override object Run(params object[] parameters)
    {
        var wordOne = parameters[0] as string;
        var wordTwo = parameters[1] as string;

        return IsRotation(wordOne!, wordTwo!);
    }
}