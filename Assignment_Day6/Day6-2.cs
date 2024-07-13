
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int length = numbers.Length;

        for (int i = 0; i < length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[length - i - 1];
            numbers[length - i - 1] = temp;
        }

        Console.WriteLine("Reversed array: " + string.Join(", ", numbers));
    }
}