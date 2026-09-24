using System;
using System.ComponentModel.DataAnnotations;
class Student
{
    private int _marks;
    public void Marks(int value)
    {
        if (_marks>=0 && _marks <= 100)
        {
            _marks=value;
        }
        else
        {
            Console.WriteLine("Invalid Marks");
        }
    }
    public void Display()
    {
        Console.WriteLine(_marks);
    }
} 
class Program
{
    public static void Main(string[] args)
    {
        Student s1=new Student();
        s1.Marks(55);
        s1.Display();
    }
}