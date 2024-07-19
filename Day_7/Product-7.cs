using System;
using System.Security.Cryptography.X509Certificates;

namespace Product
{
    class product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Qty { get; set; }

        public product(int productid)
        {
            ProductId = productid;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"ProductId: {ProductId}");

            Console.WriteLine($"ProductName: {ProductName}");
            Console.WriteLine($"ProductPrice: {ProductPrice}");
            Console.WriteLine($"ProductQty: {Qty}");
        }

    }


    class program
        {
            static void Main(string[] args)
            {
                product product = new product(1);
                product.ProductName = "Laptop";
                product.ProductPrice = 1000000;
                product.Qty = 10;



            product.DisplayProductDetails();

               

        }

    }
}