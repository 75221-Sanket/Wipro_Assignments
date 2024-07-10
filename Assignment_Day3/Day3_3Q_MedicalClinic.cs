using System;

class Patieint
{

        static void Main()
        {
            Console.WriteLine("Enter pateint Id");
            int pateintId = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter patient name");
            string patientName = (Console.ReadLine());


            Console.WriteLine("is old patient");
            bool isOld = bool.Parse(Console.ReadLine());

        Console.WriteLine("Enter patieint Age");
        int Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Weight of patieint ");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the patient Body Tem");
        double ptamp = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Amount");
        int Amount = int.Parse(Console.ReadLine());

        DateTime d = new DateTime();
        Console.WriteLine("Enter the joining Date and Time (dd/mm/yyyy)");
        d = DateTime.Parse(Console.ReadLine());



        Console.WriteLine("\npatient info:");
            Console.WriteLine($"patient ID : {pateintId}");
            Console.WriteLine($"patientName: {patientName}");
            Console.WriteLine($"is Old patient:{isOld:c}");
            Console.WriteLine($"Enter the Age of patient: {Age}");
            Console.WriteLine($"Enter the weight of the patient: {weight}");
            Console.WriteLine($"Body tem: {ptamp}");
            Console.WriteLine($"Enter the Amount: {Amount}");
          

            Console.ReadLine();

        }
    }

