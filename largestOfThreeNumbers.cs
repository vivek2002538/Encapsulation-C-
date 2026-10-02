for(int i = 0; i < 3; i++)
{
    Console.Write("enter first number: ");
    int n1=Convert.ToInt32(Console.ReadLine());
    Console.Write("enter second number: ");
    int n2=Convert.ToInt32(Console.ReadLine());
    Console.Write("enter third number: ");
    int n3=Convert.ToInt32(Console.ReadLine());
    if (n1>n2 && n1 > n3)
    {
        Console.WriteLine($"largest: {n1}");
    }
    else if (n2>n1 && n2 > n3)
    {
        Console.WriteLine($"largest: {n2}"); 
    }
    else
    {
        Console.WriteLine($"largest :{n3}");
    }
}