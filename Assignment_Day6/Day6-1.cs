


using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 5, 7, 2, 8, 10, 6 };
        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                second = num;
            }
        }

        Console.WriteLine("The second largest element is: " + second);
    }
}
