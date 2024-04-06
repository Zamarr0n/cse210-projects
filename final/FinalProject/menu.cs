using System;

// This function will only print the menu after display all the data 
// of the user.

public class Menu{
    private string _menu = $@"

Menu Options 
===============================================
Please select one of the following options: (Please only enter the number).
    
1.- Set a Saving Goal
2.- Learn about financial education 
3.- Saving Data
4.- End Program
    ";
    private string menuFunds = $@"
Please select one of the options:
===============================================
(Remember to only enter the number of the Item)

1.- Vacations Fund
2.- Emergency Fund

        ";
    public string _userInput;
    // private int _userChoice;
    private bool _continue = true;
    // private string expenses_article = "https://hbr.org/2022/11/5-ways-to-manage-your-personal-finances";
    // private string stock_market = "https://fortune.com/recommends/investing/how-to-start-investing/";
    // private string emergency_fund = "https://www.consumerfinance.gov/an-essential-guide-to-building-an-emergency-fund/";

    private int user_vacations;
    private int user_emergency;
    financialEducation finance = new financialEducation();
    SavingGoals savingGoal = new SavingGoals();
    Saving save = new Saving();


    public void UserChoice(string userName, int salary, int freelancing_earnings, int rent , int groceries){
        while (_continue == true)
        {
            Console.WriteLine(_menu);
        int _userInput = int.Parse(Console.ReadLine());
        if(_userInput == 1){
            Console.WriteLine("Saving Goal");
            Console.WriteLine(menuFunds);
            Console.Write("Which goal would you like to set:");
            int inputUser = int.Parse(Console.ReadLine());
            if (inputUser == 1){
                user_vacations = savingGoal.vacationFund();
            } else if(inputUser == 2){
                user_emergency = savingGoal.emergencyFund();
            }
        } else if(_userInput == 2){
            Console.WriteLine("Learn financial education");
            Console.WriteLine(finance.financialTips());
        } else if(_userInput == 3){
            Console.WriteLine("Saving data....");
            Console.WriteLine("In order to save your data you most put an amount in all the requirements (or the program could fail)");
            Console.WriteLine("Do you still want to continue? Y/N: ");
            string answer = Console.ReadLine();
            if(answer =="Y"){
                // need all the parmeters to work
                save.savingData(userName,salary, freelancing_earnings,rent,groceries, user_vacations, user_emergency);
            }else if (answer == "N"){
                break;
            }else{
                Console.WriteLine("Please enter a valid option.");
            }
        } else if (_userInput == 4){
            //program ending
            Console.WriteLine("Thank you for your time :) ");
            // Ending the loop so the program end.
            _continue = false;
        }
        }
        

    }



}




