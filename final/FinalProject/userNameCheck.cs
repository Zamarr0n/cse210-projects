using System;


public class userNameCheck{


    public userNameCheck(string userName){
        Menu_Old_User menu = new Menu_Old_User();
        string filename = userName + ".txt";

        if(File.Exists(filename)){
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                //this separates the data " , ";
            string[] parts = line.Split(",");
            
            //map the data so it could bring it back to display it to the user.

            string UserName = parts[0];
            string salary  = parts[1];
            string freelancing_earnings = parts[2];
            string rent = parts[3];
            string groceries = parts[4];
            string emergency_fund = parts[5];
            string vacation_fund = parts[6];
            string total_savings = parts[7];

            //Converting each part into integers to latter do the operations needed.
            int salary_integer = int.Parse(salary);
            int freelancing_earnings_integer = int.Parse(freelancing_earnings);
            int rent_integer = int.Parse(rent);
            int groceries_integer = int.Parse(groceries);
            int emergency_fund_integer = int.Parse(emergency_fund);
            int vacation_fund_integer = int.Parse(vacation_fund);

            int total_income = salary_integer + freelancing_earnings_integer;
            int total_expenses = rent_integer + groceries_integer;
            int total_savings_integer = int.Parse(total_savings);

                // ------------------------- New function to display data of previous user -------------------------
            Console.WriteLine($"Welcome to your Personal Finance Dashboard, {UserName}!");
            Console.WriteLine("Is nice to see you here again :) ");
            Console.WriteLine("Overview:");
            Console.WriteLine($"Total Income:  ${total_income}");
            Console.WriteLine($"Total Expenses:  ${total_expenses}");
            Console.WriteLine($"Total Savings:  ${total_savings_integer}");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Income:");
            // Spinning();
            Console.WriteLine($"» Salary:  ${salary_integer}");
            Console.WriteLine($"» Freelance Earnings:  ${freelancing_earnings_integer}");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Expenses:");
            // Spinning();
            Console.WriteLine($"» Rent:  ${rent_integer}");
            Console.WriteLine($"» Groceries: ${groceries_integer}");
            Console.WriteLine("Savings: ");
            Console.WriteLine($"» Emergency Found: ${emergency_fund_integer}");
            Console.WriteLine($"» Vacation Found: ${vacation_fund_integer}");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Set up your budget: ");
            Console.WriteLine($"» Budget for Rent: ${rent_integer}");
        Console.WriteLine($"» Budget for Groceries: ${groceries_integer}");
            Console.WriteLine(" ");
            Console.WriteLine("Budgets updated successfully.");
            Console.WriteLine(" ");
            menu.UserChoice(UserName,salary_integer,freelancing_earnings_integer, rent_integer, groceries_integer, vacation_fund_integer,emergency_fund_integer);
            }
        }else{
            Console.WriteLine("User Name doesn´t exist, please Log in :) ");
        }
    }


}








