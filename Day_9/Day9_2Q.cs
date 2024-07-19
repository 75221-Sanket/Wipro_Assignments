using System;
using System.Collections.Generic;

public class CustomerList
{
    private Dictionary<string, List<string>> customersByPlan;

    public CustomerList()
    {
        customersByPlan = new Dictionary<string, List<string>>();
    }

    public void AddCustomerToPlan(string plan, string customerName)
    {
        if (!customersByPlan.ContainsKey(plan))
        {
            customersByPlan[plan] = new List<string>();
        }

        customersByPlan[plan].Add(customerName);
    }

    public void DisplayCustomersByPlan()
    {
        foreach (var plan in customersByPlan)
        {
            Console.WriteLine($"Plan: {plan.Key}");
            foreach (var customer in plan.Value)
            {
                Console.WriteLine($"- {customer}");
            }
        }
    }

    public static void Main()
    {
        CustomerList customerList = new CustomerList();

        // Add customers to plans
        customerList.AddCustomerToPlan("Basic", "Alice");
        customerList.AddCustomerToPlan("Premium", "Bob");
        customerList.AddCustomerToPlan("Basic", "Charlie");
        customerList.AddCustomerToPlan("Premium", "David");
        customerList.AddCustomerToPlan("Premium", "Eva");

        // Display customers by plan
        customerList.DisplayCustomersByPlan();
    }
}
