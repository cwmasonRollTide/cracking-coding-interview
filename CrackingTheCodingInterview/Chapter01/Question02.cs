using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Given two strings, write a method to decide if one is a permutation of the other
/// </summary>
public class Question02 : Question
{
    private static bool IsPermutation(string wordOne, string wordTwo)
    {
        if (wordOne.Length != wordTwo.Length) return false;
        Dictionary<char, int> wordOneCharMap = BuildCharMap(wordOne);
        Dictionary<char, int> wordTwoCharMap = BuildCharMap(wordTwo);
        return AreDictionariesEqual(wordOneCharMap, wordTwoCharMap);
    }

    /// <summary>
    /// Iterate through an input word and return a dictionary with the characters
    /// as the keys, and the value of how many times that character occurs
    /// in the word
    /// </summary>
    /// <param name="word">Input string. Any valid string</param>
    /// <returns>Dictionary of char to int, number of times each character appears in word</returns>
    private static Dictionary<char, int> BuildCharMap(string word)
    {
        var wordCharMap = new Dictionary<char, int>();
        foreach (char letter in word.ToList())
        {
            if (wordCharMap.ContainsKey(letter)) wordCharMap[letter]++;
            else wordCharMap.Add(letter, 1);
        }
        return wordCharMap;
    }
    
    /// <summary>
    /// Deep equal of two dictionaries. Order of the elements does not matter
    /// </summary>
    /// <param name="dict1"></param>
    /// <param name="dict2"></param>
    /// <typeparam name="TKey">The type of the dictionaries' keys</typeparam>
    /// <typeparam name="TValue">The type of the dictionaries' values</typeparam>
    /// <returns>Boolean indicating if they are equal or not</returns>
    private static bool AreDictionariesEqual<TKey, TValue>(
        Dictionary<TKey, TValue> dict1, 
        IReadOnlyDictionary<TKey, TValue> dict2) where TKey : notnull
    {
        return dict1.Count == dict2.Count && 
               dict1.All(pair => dict2.TryGetValue(pair.Key, out TValue? value) && 
                EqualityComparer<TValue>.Default.Equals(pair.Value, value));
    }
    
    public override object Run(params object[] parameters)
    {
        var wordOne = parameters[0] as string;
        var wordTwo = parameters[1] as string;
        return IsPermutation(wordOne!, wordTwo!);
    }
}