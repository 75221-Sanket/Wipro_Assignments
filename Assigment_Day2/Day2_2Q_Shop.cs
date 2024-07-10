using System;

class Shop
{
    static void Main()
    {
        const int pricePerPizza = 300;
        const int pricePerPuff = 50;
        const int pricePerPepsi = 130;
        const double gstRate = 0.09;
        const double cessRate = 0.09;

        Console.WriteLine("Enter the number of pizzas: ");
        int numberOfPizzas = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of puff: ");
        int numberOfPuff = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of pepsis: ");
        int numberOfPepsis = int.Parse(Console.ReadLine());


        int totalCostOfPizzas = numberOfPizzas * numberOfPizzas;
        int totalCostOfPuff = numberOfPuff * numberOfPuff;
        int totalCostOfPepsis = numberOfPepsis * numberOfPepsis;


        int totalCost = totalCostOfPizzas + totalCostOfPuff + totalCostOfPepsis;
        double gstAmount = totalCost * gstRate;
        double cessAmount = totalCost * cessRate;
        double grandTotal = totalCost + gstAmount + cessAmount;

        Console.WriteLine("Bill Details");
        Console.WriteLine($"Total cost of pizzas: Rs.{totalCostOfPizzas}");
        Console.WriteLine($"Total cost of puff: Rs.{totalCostOfPuff}");
        Console.WriteLine($"Total cost of pepsis: Rs.{totalCostOfPepsis}");
        Console.WriteLine($"Total cost: Rs.{totalCost}");
        Console.WriteLine($"Gst: Rs.{gstAmount}");
        Console.WriteLine($"CESS: Rs.{cessAmount}");
        Console.WriteLine($"Grand Total: Rs.{grandTotal}");
    }
}
