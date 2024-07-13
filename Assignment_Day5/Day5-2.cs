using System;
class program
{
    static int sumAlternateNum(int number)
    {
        int sum =0;
        int position = 1;

        while (number>0)
        {
            int digit = number % 10;
            if (position % 2 !=0)
            {
                sum+= digit;
            }
            number /= 10;
            position++;
        }
        return sum;
    }
    static void Main()
    {
        int number = 12345;
        Console.WriteLine("Input" +number);

        int sum = sumAlternateNum(number);

        Console.WriteLine("Answer" +sum);
    }
}
