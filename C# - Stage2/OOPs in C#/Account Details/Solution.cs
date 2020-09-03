using System;

public class Account
{
    public int accountNo = 0;
	public double balance;
	public string accountType;
	public static int counter = 0;

	public Account(double balance, string accountType)
	{
        this.balance = balance;
        this.accountType = accountType;
        counter++;
        accountNo = counter;
    }

    public void depositAmount(double amount)
    {
        balance = balance + amount;
    }
    
    public void printAccountDetails()
    {
        Console.WriteLine("[Acct No : {0}, Type : {1}, Balance : {2}]", accountNo, accountType, balance);
    }
}
	
public	class AccountDetails
{
 
	public void GetData()
	{
	     double balance1;
	     balance1 = Convert.ToDouble(Console.ReadLine());
		 String type1;
		 type1 = Console.ReadLine();
		 double amount1;
		 amount1 = Convert.ToDouble(Console.ReadLine());
		 
		 double balance2;
		 balance2 = Convert.ToDouble(Console.ReadLine());
		 String type2;
		 type2 = Console.ReadLine();
		 //double amount2 = Convert.ToDouble(Console.ReadLine());

		
		Account a1 = new Account(balance1, type1);
		a1.printAccountDetails();
		a1.depositAmount(amount1);
		Console.WriteLine("New Balance : {0:N}");
		
		Account a2 = new Account(balance2, type2);
		a2.printAccountDetails();
		Console.WriteLine("New Balance : {0:N}");

	}
}