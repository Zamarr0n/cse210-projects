using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Personal Finance Management");
        Console.WriteLine(" ");
        Console.WriteLine("WARNING: This project is to help people record their data and expenses, this program is not finished due the short amount of time ");
        Console.WriteLine(" I counted for developing it, so please follow the rules so the program wont crash when you want to save the data inside a file or  ");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
        Console.Write("Do you have a .txt file?: Y/N ");
        char choice = Console.ReadLine().ToUpper()[0];

        if(choice == 'Y'){
            Console.Write("Please enter the name of your file: ");
            string userName = Console.ReadLine();
            userNameCheckk previousUser = new userNameCheckk();
            previousUser.userNameCheck(userName);
            // function to display the menu for changes:


        } else if (choice == 'N'){

            Console.WriteLine("Please enter the following information: ");
            Console.WriteLine(" ");
            Console.WriteLine("PLease Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Total Income:  $");
            int total_income = int.Parse(Console.ReadLine());
            Console.Write("Total Expenses:  $");
            int total_expenses = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Savings:  ");
            Console.WriteLine(" ");
            Console.WriteLine("Please input your financial data: ");
            Console.WriteLine("Income:");
            Console.Write("» Salary:  $");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("» Freelance Earnings:  $");
            int freelance_earnings = int.Parse(Console.ReadLine());
            Console.WriteLine("Expenses:");
            Console.Write("» Rent:  $");
            int rent = int.Parse(Console.ReadLine());
            Console.Write("» Groceries: ");
            int groceries = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            //display all the data to the user:
            displayNewUserData data = new displayNewUserData(name, total_income, total_expenses,salary, freelance_earnings,rent, groceries);
            Console.WriteLine(data);
        }
        else{
            Console.WriteLine("Please Enter a valid option");
        }
    }

}