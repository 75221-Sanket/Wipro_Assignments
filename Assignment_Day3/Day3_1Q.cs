using System;

class Maxnumber1
{
    static void Main()
    {
        int maxIntValue1 = int.MaxValue;
        int maxIntValue2 = int.MaxValue;


        Console.WriteLine($"First integre (max value of int ): {maxIntValue1}");
        Console.WriteLine($"Second integer(max value of int):{maxIntValue2}");  

        long sum = (long)maxIntValue1 + (long)maxIntValue2;

        Console.WriteLine($"sum of two max int values using long:{sum}");
    }
}
