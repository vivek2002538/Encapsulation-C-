using System;
class Swap
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before: a={a},b={b}");
        (a,b)=(b,a);
        Console.WriteLine($"After: a={a},b={b}");
    }
}