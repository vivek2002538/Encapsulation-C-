using System;
class SimpleInterest
{
    public static void Main(string[] args)
    {
        Console.Write("principal: ");
        decimal principal=Convert.ToDecimal(Console.ReadLine());
        Console.Write("Rate: ");
        decimal rate=Convert.ToDecimal(Console.ReadLine());
        Console.Write("years: ");
        int years=Convert.ToInt32(Console.ReadLine());
        decimal interest=((principal/100)*rate)*years;
        Console.WriteLine($"interest: {interest}");
        Console.WriteLine($"Total: {principal+interest}");
    }
}