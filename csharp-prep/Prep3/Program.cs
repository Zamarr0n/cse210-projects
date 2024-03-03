using System;

class Program
{
    static void Main(string[] args)
    {
// Start by asking the user for the magic number. (In future steps, 
// we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
// Ask the user for a guess.
// Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
// At this point, you won't have any loops.
    Random rnd = new Random();
    string guess;
    int guessing;
    int magic_number;
    magic_number = rnd.Next(1,100);
do
{
    Console.Write("Guess the magic Number: ");
    guess = Console.ReadLine();
    guessing = int.Parse(guess);
    if(magic_number > guessing)
    {
        Console.WriteLine("Higher");
        Console.WriteLine($"Tip: the number is {magic_number}");
    }
    else if(magic_number == guessing){
        Console.Write("Nice, you guessed it :)");
    }
    else{
        Console.WriteLine("Lower");
        Console.WriteLine($"Tip: the number is {magic_number}");
    }
} while(magic_number != guessing);   
    }
}