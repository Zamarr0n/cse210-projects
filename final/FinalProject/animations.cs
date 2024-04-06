public class newUserData{


    // animation section 
    public void CountdownEvent(){
        for (int i = 5; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinning(){
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    foreach (string s in animationStrings)
    {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }
    }
    // animation section 

    
        // private int _total_income;
        // private int _total_expenses;
        // private int _salary;
        // private int _freelance_earnings;
        // private int _rent;
        // private int _groceries;

    // public newUserData(string userName, int total_income , int total_expenses , int salary , int freelance_earnings, int rent, int groceries): base (userName,total_expenses ,salary ,freelance_earnings,rent, groceries){
    //     _total_income = total_income;
    //     _total_expenses = total_expenses;
    //     _salary = salary;
    //     _freelance_earnings = freelance_earnings;
    //     _rent = rent;
    //     _groceries = groceries;
    // }
    // public void setIncome(int income){
    //     _income = income;
    // }
    // public void setSaving(int saving){
    //     _saving = saving;
    // }
    // public void setExpenses(int expenses){
    //     _expenses = expenses;
    // }
    // public void setDebts(int debts){
    //     _debts = debts;
    // }
    // public void setInvestment(int investment){
    //     _investment = investment;
    // }

    // public int getTotalIncome(){
    //     return _total_income;
    // }
    // public int getTotalExpenses(){
    //     return _total_expenses;
    // }
    // public int getSaving(){
    //     return _saving;
    // }
    // public int getDebt(){
    //     return _debts;
    // }
    // public int getInvestment(){
    //     return _investment;
    // } 








}