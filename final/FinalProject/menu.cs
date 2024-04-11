using System;

// This function will only print the menu after display all the data 
// of the user.

public class Menu{

    public string _userInput;
    // private int _userChoice;
    private bool _continue = true;
    private int user_vacations;
    private int user_emergency;
    financialEducation finance = new financialEducation();
    Goals savingGoal = new Goals();
    Saving save = new Saving();

    Animations animation = new Animations();

    public void UserChoice(string userName, int salary, int freelancing_earnings, int rent , int groceries){
        while (_continue == true)
        {
            Console.WriteLine(Menu_string());
        int _userInput = int.Parse(Console.ReadLine());
        if(_userInput == 1){
            Console.Write("Saving Goal");
            animation.CountdownEvent();
            Console.WriteLine(menu_goals());
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
            animation.Spinning();
            Console.WriteLine("In order to save your data you most put an amount in all the requirements (or the program could fail)");
            Console.WriteLine("Do you still want to continue? Y/N: ");
            string answer = Console.ReadLine();
            if(answer =="Y"){
                save.savingData(userName,salary, freelancing_earnings,rent,groceries, user_vacations, user_emergency);
            }else if (answer == "N"){
                break;
            }else{
                Console.WriteLine("Please enter a valid option.");
            }
        }else if (_userInput == 4){
            Console.WriteLine("You cant withdraw money from you account right now");
        } 
        else if (_userInput == 5){
            //program ending
            Console.WriteLine($"Thank you {userName} for your time :) ");
            // Ending the loop so the program end.
            _continue = false;
        }
        }
        

    }

public string Menu_string(){
    string _menu = $@"

Menu Options 
===============================================
Please select one of the following options: (Please only enter the number).
    
1.- Set a Saving Goal
2.- Learn about financial education 
3.- Saving Data
4.- Withdraw
5.- End Program
    ";
    return _menu;
}

public string menu_goals(){
    string menuFunds =  $@"
Please select one of the options:
===============================================
(Remember to only enter the number of the Item)

1.- Savings Fund
2.- Emergency Fund

        ";
    return menuFunds;
}
}




