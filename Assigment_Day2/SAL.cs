using System;

    class program
{
    static void Main()
    {
        Console.WriteLine("Enter Employee ID");
        int employeeId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employee Name");
        string employeeName = (Console.ReadLine());

        Console.WriteLine("Enter Employee Salary");
        double basicSalary = double.Parse(Console.ReadLine());

        Console.WriteLine("Is Contract Employee (true?false)");
        bool isContractEmployee = bool.Parse(Console.ReadLine());

        Console.WriteLine("Enter Department number: ");
        int deptno = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Email ID");
        string emailId = (Console.ReadLine());


        double hra = 0.15 * basicSalary;
        double ma = 0.10 * basicSalary;
        double ta = 0.15 * basicSalary;

        double netSalary = basicSalary + ma + ta;

        Console.WriteLine("\nEmployee Datails");
        Console.WriteLine($"ID: {employeeId}");
        Console.WriteLine($"Name: {employeeName} ");
        Console.WriteLine($"Basic Salary:{basicSalary} ");
        Console.WriteLine($"Is Contract Employee:{isContractEmployee} ");
        Console.WriteLine($"Department number :{deptno}");
        Console.WriteLine($"Email ID: {emailId}");
        Console.WriteLine($"HRA:{hra} ");
        Console.WriteLine($"ma:{ma} ");
        Console.WriteLine($"ta:{ta} ");


    }
}