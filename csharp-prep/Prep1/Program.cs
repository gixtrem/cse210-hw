using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("What is your first name? ");
    string firstname = Console.ReadLine();
    Console.Write("Whats your last name? ");
    string lastname = Console.ReadLine();
    Console.WriteLine($"Your name is, {firstname} {lastname}.");

    }
}
