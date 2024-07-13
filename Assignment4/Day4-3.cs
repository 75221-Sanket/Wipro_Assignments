using System;

class EvenOdd
{
    static void Main()
    {
        int[] numbers = new int[20];

        int sumEven = 0;
        int sumOdd = 0;

        Console.WriteLine("please enter 20 numbers:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Enter number {i + 1}:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 20; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sumEven += numbers[i];
            }
            else
            {
                sumOdd += numbers[i];
            }
        }
        Console.WriteLine($"sum of even number:{sumEven}");
        Console.WriteLine($"sum of odd number:{sumOdd}");

    }
}
