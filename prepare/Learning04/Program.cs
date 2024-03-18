using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1= new Assignment("Emilio","Math");
        Console.Write(student1.GetSummary());
    }
}