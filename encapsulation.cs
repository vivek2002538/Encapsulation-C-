using System;
class BankAccount
{
    private int balance;
    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance+=amount;
        }
        else
        {
            Console.WriteLine("inavlid Amount");
        }
    }
    public int GetBalance()
    {
        return balance;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        BankAccount b1= new BankAccount();
        b1.Deposit(1000);
        Console.WriteLine(b1.GetBalance());
    }
}