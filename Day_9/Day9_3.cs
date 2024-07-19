using System;
using System.Collections.Generic;

public class TimeInWords
{
    private static readonly Dictionary<int, string> numberToWords = new Dictionary<int, string>
    {
        { 0, "o' clock" }, { 1, "one" }, { 2, "two" }, { 3, "three" },
        { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" },
        { 8, "eight" }, { 9, "nine" }, { 10, "ten" }, { 11, "eleven" },
        { 12, "twelve" }, { 13, "thirteen" }, { 14, "fourteen" }, { 15, "quarter" },
        { 16, "sixteen" }, { 17, "seventeen" }, { 18, "eighteen" }, { 19, "nineteen" },
        { 20, "twenty" }, { 21, "twenty one" }, { 22, "twenty two" }, { 23, "twenty three" },
        { 24, "twenty four" }, { 25, "twenty five" }, { 26, "twenty six" }, { 27, "twenty seven" },
        { 28, "twenty eight" }, { 29, "twenty nine" }, { 30, "half" }
    };

    public static string TimeToWords(int hours, int minutes)
    {
        if (minutes == 0)
        {
            return $"{numberToWords[hours]} {numberToWords[minutes]}";
        }
        else if (minutes == 15 || minutes == 30)
        {
            return $"{numberToWords[minutes]} past {numberToWords[hours]}";
        }
        else if (minutes == 45)
        {
            return $"{numberToWords[15]} to {numberToWords[(hours % 12) + 1]}";
        }
        else if (minutes < 30)
        {
            return $"{numberToWords[minutes]} minute{(minutes == 1 ? "" : "s")} past {numberToWords[hours]}";
        }
        else
        {
            int remainingMinutes = 60 - minutes;
            return $"{numberToWords[remainingMinutes]} minute{(remainingMinutes == 1 ? "" : "s")} to {numberToWords[(hours % 12) + 1]}";
        }
    }

    public static void Main()
    {
        Console.Write("Enter hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        string timeInWords = TimeToWords(hours, minutes);
        Console.WriteLine(timeInWords);
    }
}

