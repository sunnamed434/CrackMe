using System;

namespace CrackMe_0
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (password == "hobbits")
            {
                Console.WriteLine("Password is right! Good job!");
            }
            else
            {
                Console.WriteLine("Password is not right! Bad job..");
            }

            Console.ReadLine();
        }
    }
}
