using System;

class Program
{
    static void Main(string[] args)
    {
// Write a program that determines the letter grade for a course according to the following scale:
// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60

// Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. 
// (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
// Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. 
// If not, display a different message to encourage them for next time.
// Change your code from the first part, so that instead of printing the letter grade in the body of each if, 
// elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
// Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
        Console.Write("Grade: ");
        string grade = Console.ReadLine();
        int Letter = int.Parse(grade);
        if(Letter >= 90 ){
            Console.WriteLine($"Your Grade is A {Letter}");
        }
        else if (Letter >= 80){
            Console.WriteLine($"Your Grade is B {Letter}");
        }
        else if(Letter >= 70)
        {
            Console.WriteLine($"Your grade is C {Letter}");
        }
        else if (Letter >= 60)
        {
            Console.WriteLine($"Your Grade is D {Letter}");
        }
        else if(Letter < 60)
        {
            Console.WriteLine($"Your Grade is F {Letter}");
        }
        if(Letter >= 85){
            Console.WriteLine("Congratulations you have pass the subject ");
        }
        else if (Letter >=70){
            Console.WriteLine("You have pass the course with the minimum grade ");
        }
        else{
            Console.Write("Sometimes is difficult to keep the trace, but I know you will achieve it, this is just a setback");
            Console.Write("YOU CAN DO IT!!");
        }
    }
}