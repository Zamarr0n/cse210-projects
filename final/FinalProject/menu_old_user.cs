using System;


public class Menu_Old_User : Menu {

    Menu menu_string = new Menu();
    financialEducation finance = new financialEducation();
    Goals Goal = new Goals();
    Saving save = new Saving();
    Animations spinning_animation = new Animations();
    bool _continue = true;
    private int new_user_vacations;
    private int new_user_emergency;

    public void UserChoice(string userName, int salary, int freelancing_earnings, int rent , int groceries, int user_vacations, int user_emergency){
        while (_continue == true)
        {
            Console.WriteLine(menu_string.Menu_string());
        int _userInput = int.Parse(Console.ReadLine());
        if(_userInput == 1){
            Console.Write("Saving Goal");
            spinning_animation.Spinning();
            Console.WriteLine("");
            Console.WriteLine(menu_string.menu_goals());
            Console.Write("Which goal would you like to set:");
            int inputUser = int.Parse(Console.ReadLine());
            if (inputUser == 1){
                
                new_user_vacations = Goal.FundAdding(user_vacations);
            } else if(inputUser == 2){

                new_user_emergency = Goal.FundAdding(user_emergency);
            }
        } else if(_userInput == 2){
            Console.WriteLine("Learn financial education");
            spinning_animation.Spinning();
            Console.WriteLine(finance.financialTips());
        } else if(_userInput == 3){
            Console.Write("Saving data....");
            spinning_animation.Spinning();
            Console.WriteLine(" ");
            Console.WriteLine("In order to save your data you most put an amount in all the requirements (or the program could fail)");
            Console.WriteLine("");
            Console.WriteLine("Do you still want to continue? Y/N: ");
            string answer = Console.ReadLine();
            if(answer =="Y"){
                Console.WriteLine("Please provide the name of your file: ");
                string textFile = Console.ReadLine();
                save.savingData(textFile,salary, freelancing_earnings,rent,groceries, new_user_emergency, new_user_vacations);
            }else if (answer == "N"){
                break;
            }
            else{
                Console.WriteLine("Please enter a valid option.");
            }
            }else if (_userInput == 4){
                //implement function to withdraw money:
                Console.WriteLine("WARNING: This money will be take from your savings and will not have any effect in the emergency funds");
                Console.Write("Please enter the quantity of money you would like to withdraw: (Remember to only type whole numbers) ");
                int answer = int.Parse(Console.ReadLine());
                userNameCheckk parameter = new userNameCheckk();
                int balance = parameter.setSavings(userName);
                //parameter of withdraw is balance:
                CheckingAccount withdraw = new CheckingAccount(balance);
                withdraw.Withdraw(answer);
                int final_balance = withdraw.GetBalance();
                Console.WriteLine($"this is your total savings now: {final_balance}");
                    new_user_vacations = Goal.FundSubstraction(user_vacations,answer);
                    new_user_emergency = user_emergency;
            } else if (_userInput == 5){
            //program ending
            Console.WriteLine($"Thank you {userName}!!  for your time :) ");
            Console.Write("...");
            spinning_animation.CountdownEvent();
            // Ending the loop so the program end.
            _continue = false;
        }
        }
        
    }
}


