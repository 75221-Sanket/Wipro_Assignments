using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        string result = ConvertNumberToWords(input);
        
        Console.WriteLine("Output: " + result);
    }

    static string ConvertNumberToWords(string number)
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        
        string result = "";
        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                int num = digit - '0';
                result += words[num] + " ";
            }
            else
            {
                return "Invalid input!";
            }
        }
        
        return result.Trim();
    }
}
