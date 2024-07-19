using System;

class program
{
    static void Main()
    {
        string[] ar = { "Book", "pen", "Charts" };

        string result = "";

        for (int i = 0; i < ar.Length; i++)
        {
            result += ar[i];
            if (i < ar.Length - 1)
            {
                result += ",";
            }

        }
        Console.WriteLine("Output : " + result);
    }
}