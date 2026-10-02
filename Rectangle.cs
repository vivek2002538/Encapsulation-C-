using System;
class Rectangle
{
    public static void Main(string[] args)
    {
        Console.Write("Enter width: ");
        int width=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height: ");
        int height=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Area: {width*height}");
        Console.WriteLine($"Perimeter: {2*(width+height)}");
    }
}