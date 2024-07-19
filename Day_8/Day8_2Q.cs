
using System;
using System.Collections.Generic;

public class EqualCharacterWordsCounter
{
    public static int CountEqualCharacterWords(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        List<string> words = new List<string>();
        int wordStart = -1;

        // Extract words from the string
        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsWhiteSpace(input[i]))
            {
                if (wordStart == -1)
                {
                    wordStart = i;
                }
            }
            else
            {
                if (wordStart != -1)
                {
                    words.Add(input.Substring(wordStart, i - wordStart));
                    wordStart = -1;
                }
            }
        }

        if (wordStart != -1)
        {
            words.Add(input.Substring(wordStart));
        }

        // Count words by their lengths
        Dictionary<int, int> lengthCounts = new Dictionary<int, int>();

        foreach (string word in words)
        {
            int length = word.Length;
            if (lengthCounts.ContainsKey(length))
            {
                lengthCounts[length]++;
            }
            else
            {
                lengthCounts[length] = 1;
            }
        }

        // Count the number of words with equal number of characters
        int equalCharacterWordsCount = 0;

        foreach (var pair in lengthCounts)
        {
            if (pair.Value > 1)
            {
                equalCharacterWordsCount += pair.Value;
            }
        }

        return equalCharacterWordsCount;
    }

    public static void Main()
    {
        string[] inputs = {
            "Hi  How are you",
            "You are best thing",
            "Practice makes man perfect"
        };

        foreach (string input in inputs)
        {
            int count = CountEqualCharacterWords(input);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {count}");
            Console.WriteLine();
        }
    }
}
