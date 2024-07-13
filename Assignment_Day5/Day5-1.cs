using System;

namespace Admin
{
    class Admin
    {
        static bool lsValidUser(string username, string password)
        {
            if (username.Trim() == "admin" && password.Trim() == "admin123")
            {
                return true;
            }
            else
            {
                return false;
            }
            static void Main(string[] args)
            {
                int count = 0;
                do
                {
                    Console.WriteLine("Enter the username :");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();

                    bool result = lsValidUser(username, password);

                    if (result)
                    {
                        Console.WriteLine("Welcome to {0}", username);
                        break;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine("Invalid User Id or Password. Wrong Attempts count " + count);

                        if (count == 3)
                        {
                            Console.WriteLine("you account is locked");
                            break;
                        }
                    }


                } while (count < 3);

                Console.ReadLine();
            }
            }
        }
    }
