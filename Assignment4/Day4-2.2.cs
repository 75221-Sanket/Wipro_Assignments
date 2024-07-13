using System;


class FibonacciSerise
{
    static void Main()
    {
        
        int n1 = 0, n2 = 1,n3,count = 14;
        Console.Write("fibonacci series:"+count+"terms:");
        for (int i = 0; i <= count; i++)
        {
            Console.Write(n1 + " ");
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
        }
    }
}