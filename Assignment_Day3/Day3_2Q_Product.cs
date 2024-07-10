using System;

namespace productdis
{ 

class product
{
    static void Main()
    {
        Console.WriteLine("Enter product Id");
        int productId = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter product name");
        string productName = (Console.ReadLine());


        Console.WriteLine("Enter product price");
        decimal productprice = decimal.Parse(Console.ReadLine());


        Console.WriteLine("Enter product Quantity");
        int productQuantity = int.Parse(Console.ReadLine());

        decimal totalAmount = productprice * productQuantity;

        decimal discountRate = 0;

        if (totalAmount > 5000)
        {
            discountRate = 0.20m;
        }
        else if (totalAmount > 3000)
        {
            discountRate = 0.15m;
        }
        else if (totalAmount > 1000)
        {
            discountRate = 0.10m;
        }
        decimal discountAmount = totalAmount * discountRate;
        decimal discountedTotal = totalAmount - discountAmount;

        Console.WriteLine("\nproduct info:");
        Console.WriteLine($"product Id : {productId}");
        Console.WriteLine($"product Nmae: {productName}");
        Console.WriteLine($"productprice:{productprice:c}");
        Console.WriteLine($"productQuantity: {productQuantity}");
        Console.WriteLine($"Total Amount: {totalAmount:c}");
        Console.WriteLine($"Discount Amount: {discountRate:p}");
        Console.WriteLine($"Discount Amount: {discountAmount:c}");
        Console.WriteLine($"Discount Amount: {discountedTotal:c}");

        Console.ReadLine();

    }
    }
}