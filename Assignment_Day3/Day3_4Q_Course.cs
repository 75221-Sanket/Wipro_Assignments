using System;

class Program
{
    static void Main(string[] args)
    {
        const double baseCourseFee = 250000;
        DateTime lastDate = new DateTime(2024, 6, 20);
        DateTime discount10Date = new DateTime(2024, 6, 10);
        DateTime discount15Date = new DateTime(2024, 6, 15);

        var subscribers = new (string Name, DateTime RegistrationDate)[]
        {
            ("Alice",new DateTime(2024,6,5)),
             ("Bob",new DateTime(2024,6,12)),
              ("Charlie",new DateTime(2024,6,18)),
               ("Dave",new DateTime(2024,6,22)),
                ("Eve",new DateTime(2024,6,23)),


        };
        foreach (var subscriber in subscribers)
        {
            double finalFee = baseCourseFee;

            if (subscriber.RegistrationDate <= discount10Date)
            {
                finalFee *= 0.90;
            }
            else if(subscriber.RegistrationDate <= discount15Date)
            {
                finalFee *= 0.85;
            }
            else if(subscriber.RegistrationDate > lastDate)
            {
                finalFee *= 1.05;
            }
            Console.WriteLine($"Name:{subscriber.Name},Registration Date:{subscriber.RegistrationDate:yyyy-MM-dd},Course Fee:{finalFee}");
        }
    }
}