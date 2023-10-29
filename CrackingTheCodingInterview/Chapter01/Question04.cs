using System.Net;
using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase
/// that is the same for... A permutation is rearrangement of letters. Not limited
/// to words in the dictionary, can be random letters palindrome
/// </summary>
public class Question04 : Question
{
    /// <summary>
    /// Build a character map that should have values 0 or one occurrence of 1 only
    /// Then it would be a permutation of a palindrome, because if you add one to a
    /// character map when you find the first instance of a character, then decrease that
    /// value if it has already been added with a one before, the value would then be zero. 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private static bool IsPalindrome(string input)
    {
        Dictionary<char, int> map = BuildCharMap(input);
        var oneValuesFound = 0;
        bool result = map.All(x =>
        {
            if (x.Value != 1) return x.Value == 0;
            
            oneValuesFound++;
            return true;
        });
        bool isPalindrome = result;
        if (oneValuesFound > 1) 
            isPalindrome = false;
        return isPalindrome;
    }

    /// <summary>
    /// Iterate through the chars of a string word. If a char is not
    /// in the dictionary, add it. if it already has been found in the word, lower
    /// the value by one. Palindrome will have all zeroes or one key with value 1
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    private static Dictionary<char, int> BuildCharMap(string word)
    {
        var wordCharMap = new Dictionary<char, int>();
        foreach (char letter in word.ToList().Where(letter => !char.IsWhiteSpace(letter)))
        {
            char lowered = char.ToLower(letter);
            if (wordCharMap.ContainsKey(lowered)) wordCharMap[lowered]--;
            else wordCharMap.Add(lowered, 1);
        }
        return wordCharMap;
    }

    public override void Run()
    {
        var testCases = new List<string>
        {
            "Tact Coa", "randomword", "leggel", "leggel two"
        };
        var expected = new List<bool>
        {
            true, false, true, false
        };
        for (var i = 0; i < testCases.Count; i++)
        {
            bool result = IsPalindrome(testCases[i]);
            Console.WriteLine("Test Word: " + testCases[i] + 
                              "\nPassed Test: " + result.Equals(expected[i]));
        }
    }
}