public class CheckingAccount : Account
{
    public CheckingAccount(int balance) : base(balance)
    {
    }

    public override void Withdraw(int amount)
    {
        int maxWithdrawal = 200;
        if (amount <= balance1 && amount <= maxWithdrawal)
        {
            balance1 -= amount;

        } else if(amount > maxWithdrawal){
            Console.WriteLine("You only can withdraw a max of $200");
        }
    }
}