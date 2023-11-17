using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Write a method to replace all spaces in a string with percent twenty you may assume
/// that the string has sufficient space at the end to hold the additional characters and
/// that you are given the "true" length of the string. 
/// </summary>
public class Question03 : Question
{
    private static string UrlIfy(string input, int trueLength)
    {
        string? trimmed = input[..trueLength];
        return trimmed?.Replace(" ", "%20") ?? input;
    }
    
    public override object Run(params object[] parameters)
    {
        var phrase = (parameters[0] as string)!;
        int trueLength = parameters[1] as int? ?? 0;
        return UrlIfy(phrase, trueLength);
    }
}