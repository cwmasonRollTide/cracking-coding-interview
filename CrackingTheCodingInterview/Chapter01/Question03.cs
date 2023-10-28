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
    
    public override void Run()
    {
        var testCases = new Tuple<string, int>[]
        {
            new("Mr John Smith     ", 13 ),
            new ("Mr Connor Mason     ", 15),
            new ("Another Test Case     ", 17)
        };
        var expected = new[] { "Mr%20John%20Smith", "Mr%20Connor%20Mason", "Another%20Test%20Case" };
        for (var i = 0; i < testCases.Length; i++)
        {
            string result = UrlIfy(testCases[i].Item1, testCases[i].Item2);
            Console.WriteLine("Test Word: " + testCases[i].Item1 + 
                              $"\nResult: {result}" + 
                              "\nPassed Test: " + result.Equals(expected[i]));
        }
    }
}