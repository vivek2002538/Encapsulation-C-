using System;

class Program
{
    static void Main()
    {
        int choice;
        decimal balance = 1000;

        do
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("Amount deposited.");
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                    if (withdraw <= balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine("Amount withdrawn.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Balance: {balance}");
                    break;
                case 4:
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 4);
    }
}