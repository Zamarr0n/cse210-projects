using System;

class Program
{
// What is your first name? Scott
// What is your last name? Burton
// Your name is Burton, Scott Burton.
    static void Main(string[] args)
    {
        Console.Write("Whats your First Name? ");
        string first_name = Console.ReadLine();
        Console.Write("Whats your Last Name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"Your Name is {last_name}, {first_name} {last_name}");
    }
}