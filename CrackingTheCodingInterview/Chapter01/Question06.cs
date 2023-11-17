using System.Text;
using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

public class Question06 : Question
{
    private static string Compress(string input)
    {
        var characterCount = 0;
        char currentCharacter = input[0];
        var builtString = new StringBuilder();
        foreach (char c in input)
        {
            if (c == currentCharacter) 
                characterCount++;
            else
            {
                builtString.Append($"{currentCharacter}{characterCount}");
                characterCount = 1;
                currentCharacter = c;
            }
        }
        builtString.Append($"{currentCharacter}{characterCount}");

        return builtString.Length > input.Length ? 
            input : 
            builtString.ToString();
    }
    public override object Run(params object[] parameters)
    {
        var input = parameters[0] as string;
        return Compress(input!);
    }
}