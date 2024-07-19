using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }

    public string CustomerCity { get; set; }

    public Customer()
    {
        CustomerId = 0;
        CustomerName = "";
        CustomerCity = "";
    }

    public Customer(int id)
    {
        CustomerId = id;
        CustomerName = "";
        CustomerCity = "";
    }
    public Customer(int id, string name)
    {
        CustomerId = id;
        CustomerName = name;
        CustomerCity = "";
    }
    public Customer(int id, string name, string city)
    {
        CustomerId = id;
        CustomerName = name;
        CustomerCity = city;
    }
    class program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer(10256);
            Customer c3 = new Customer(10256, "Scott");
            Customer c4 = new Customer(10256, "Scott", "Hyd");

            Console.WriteLine("Customer Details : Id : {0}, name : {1}, city : {2}",c1.CustomerId,c1.CustomerName,c1.CustomerCity);
            Console.WriteLine("Customer Details : Id : {0}, name : {1}, city : {2}",c2.CustomerId,c2.CustomerName,c2.CustomerCity);
            Console.WriteLine("Customer Details : Id : {0}, name : {1}, city : {2}",c3.CustomerId,c3.CustomerName,c3.CustomerCity);
            Console.WriteLine("Customer Details : Id : {0}, name : {1}, city : {2}", c4.CustomerId, c4.CustomerName, c4.CustomerCity);

            Console.ReadLine();
        
        }
    }
}