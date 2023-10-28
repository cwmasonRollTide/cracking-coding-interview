﻿using CrackingTheCodingInterview.Shared;

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
    
    public override void Run()
    {
        string[] words = { "abcde", "hello", "apple", "kite", "padle" };
        bool[] expected = { true, false, false, true, true };

        for (var i = 0; i < words.Length; i++)
        {
            bool result = IsUniqueChars(words[i]);
            Console.WriteLine("Test Word: " + words[i] + " : " + result + "\nPassed Test: " + (result == expected[i]));
        }
    }
}