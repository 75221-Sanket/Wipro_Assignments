using System;

class Product
{
    static void Main()
    {
        decimal[] price = new decimal[5];
        int[]quantities = new int[5];

        decimal totalAmount = 0;
        
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine($"Enter price of product {count + 1}: ");
            price[count] = int .Parse( Console.ReadLine() );

            Console.WriteLine($"Enter quantity of product { count}");
            quantities[count] = int.Parse( Console.ReadLine() );

            count++;
        }
        count =0;
        while (count < 5)
        {
            totalAmount += price[count] * quantities[count];
            count++;
        }

        Console.WriteLine($"Total amount for all product : {totalAmount:c}");

    }
}