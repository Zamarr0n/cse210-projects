using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
// Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.
// Compute the sum, or total, of the numbers in the list.
// Compute the average of the numbers in the list.
// Find the maximum, or largest, number in the list.
    int new_number;
    List<int>list_numbers = new List<int>();
    Console.WriteLine("Enter a list of numbers, type 0 when finished");
    do
    {
        Console.Write("Enter Number: ");
        string input_number = Console.ReadLine();
        new_number = int.Parse(input_number);
        list_numbers.Add(new_number);

    }while(new_number != 0);
    int sum =0;
    int max_number = 0;
    int length = list_numbers.Count;
    int real_length = length - 1;
    foreach (int numbers in list_numbers)
    {
        sum+= numbers;
    }
    foreach(int number in list_numbers){
        if (max_number < number){
            max_number = number;
        }
    }
    float average = sum / real_length;
    Console.WriteLine($"This is the sum of the list:{sum}");
    Console.WriteLine($"Largest Number: {max_number}");
    Console.WriteLine($"Average: {average}");
    }
}