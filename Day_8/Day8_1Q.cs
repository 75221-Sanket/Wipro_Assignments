using System;


public class WordCounter
{
    public static int CountWords(string input)
    {
        if (input == null || input.Length == 0)
        {
            return 0;
        }

        int wordCount = 0;
        bool inWord = false;

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsWhiteSpace(input[i]))
            {
                if (inWord)
                {
                    wordCount++;
                    inWord = false;
                }
            }
            else
            {
                inWord = true;
            }
        }

        // If the last character is not a whitespace, add the last word
        if (inWord)
        {
            wordCount++;
        }

        return wordCount;
    }

    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);
        Console.WriteLine("Number of words: " + wordCount);
    }
}
