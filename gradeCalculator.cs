Console.Write("enter marks");
int n=Convert.ToInt32(Console.ReadLine());
if (n < 100)
{
    if (n > 90)
    {
        Console.WriteLine("Grade A");
    }
    else if (75 <= n && n<= 89)
    {
        Console.WriteLine("Grade B");
    }
    else if (60 <= n && n<= 74)
    {
        Console.WriteLine("Grade c");
    }
    else if (40 <= n && n<= 59)
    {
        Console.WriteLine("Grade d");        
    }
    else
    {
        Console.WriteLine("Fail");             
    }
}
