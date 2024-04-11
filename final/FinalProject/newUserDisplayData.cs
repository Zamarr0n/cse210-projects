using System.Security.Cryptography.X509Certificates;

public class displayNewUserData {

        private string _userName;
        private int _total_income;
        private int _total_expenses;
        private int _salary;
        private int _freelance_earnings;
        private int _rent;
        private int _groceries;
        Menu menu = new Menu();


    public displayNewUserData(string userName, int total_income,int total_expenses, int salary, int freelance_earnings, int rent, int groceries){
            
                // ------------------------- New function to display data to the new user -------------------------
            Console.WriteLine($"Welcome to your Personal Finance Dashboard, {userName}!");
            Console.WriteLine("Overview:");
            Console.WriteLine($"Total Income:  ${total_income}");
            Console.WriteLine($"Total Expenses:  ${total_expenses }");
            Console.WriteLine("Total Savings:  ");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Income:");
            // Spinning();
            Console.WriteLine($"» Salary:  ${salary}");
            Console.WriteLine($"» Freelance Earnings:  ${freelance_earnings}");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Expenses:");
            // Spinning();
            Console.WriteLine($"» Rent:  ${rent}");
            Console.WriteLine($"» Groceries: ${groceries}");
            Console.WriteLine("Savings: ");
            Console.WriteLine("» Emergency Found: ");
            Console.WriteLine("» Vacation Found: ");
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Set up your budget: ");
            Console.WriteLine($"» Budget for Rent: ${rent}");
        Console.WriteLine($"» Budget for Groceries: ${groceries}");
            Console.WriteLine(" ");
            Console.WriteLine("Budgets updated successfully.");
            newAccount(userName, total_income,total_expenses, salary,freelance_earnings, rent, groceries);
            Console.WriteLine(" ");
            
            menu.UserChoice(userName,salary,freelance_earnings,rent, groceries);


            // ------------------------- End of function -------------------------
            
            

    }


    // the data of the new user will be set here 
    public (string, int, int, int, int, int, int) newAccount(string userName, int total_income , int total_expenses , int salary , int freelance_earnings, int rent, int groceries){
        _userName = userName;
        _total_income = total_income;
        _total_expenses = total_expenses;
        _salary = salary;
        _freelance_earnings = freelance_earnings;
        _rent = rent;
        _groceries = groceries;
        // Console.WriteLine($"{_userName},{_total_income},{_total_expenses},{_salary},{_freelance_earnings},{_rent},{_groceries}");
        return (_userName, _total_income, _total_expenses, _salary, _freelance_earnings, _rent, _groceries);
    }


}