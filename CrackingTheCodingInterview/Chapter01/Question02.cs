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
    
    private static bool AreDictionariesEqual<TKey, TValue>(
        Dictionary<TKey, TValue> dict1, 
        IReadOnlyDictionary<TKey, TValue> dict2) where TKey : notnull
    {
        return dict1.Count == dict2.Count && 
               dict1.All(pair => dict2.TryGetValue(pair.Key, out TValue? value) && 
                EqualityComparer<TValue>.Default.Equals(pair.Value, value));
    }
    
    public override void Run()
    {
        var testCases = new Tuple<string, string>[]
        {
            new("abcde", "edcba"),
            new("deer", "reed"),
            new("xxyyzz", "yyyyyy"),
            new("zzyyi", "yyizz"),
            new("poiejfi", "ipoiejf"),
            new("zzzzzzzzzzzz", "zzzz")
        };
        var expected = new[] { true, true, false, true, true, false };
        for (var i = 0; i<testCases.Length; i++)
        {
            bool result = IsPermutation(testCases[i].Item1, testCases[i].Item2);
            Console.WriteLine("Test Words: " + testCases[i].Item1 + " " + testCases[i].Item2 + "\nPassed Test: " + (result == expected[i]));
        }
    }
}