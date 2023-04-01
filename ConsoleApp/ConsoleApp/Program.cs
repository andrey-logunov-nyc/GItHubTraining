using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("GitHub Training...");
            Console.WriteLine("What's your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            Console.WriteLine($"Commit 1");
            Console.WriteLine($"Commit 2");
            Console.WriteLine($"Commit 3");

            Console.WriteLine(Operations.Add(1, 2));
            Console.WriteLine(Messages.HELLO);

            Console.ReadLine();
        }
    }
}
