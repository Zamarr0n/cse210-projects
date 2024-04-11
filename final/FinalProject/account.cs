using System;

public class Account{

    protected int balance1;

    public Account(int balance)
    {
        balance1 = balance;
    }

    // Virtual methods to be overridden by derived classes
    public virtual void Withdraw(int amount)
    {
        // Default behavior: do nothing
    }

    public int GetBalance()
    {
        return balance1;
    }


    
}


