using System;

class program
{

    static void PrintWords(string input)
    {
        string word = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                Console.WriteLine(word);
                word = "";
            }
            else
            {
                word += input[i];
            }
        }
        Console.WriteLine(word);

    }
    static void Main()
    {
        string input = "welcome to C# Programmin";
        Console.WriteLine("Input" + input);
        Console.WriteLine("Output");

        PrintWords(input);
    }

}