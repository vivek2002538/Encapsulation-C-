Console.Write("Units Consumed: ");
int units=Convert.ToInt32(Console.ReadLine());
if (units <= 100)
{
    Console.WriteLine($"Bill: {units*5}");
}
else if(units>100 && units <= 200)
{
    Console.WriteLine($"Bill: {(100*5)+(units-100)*7}");
}
else
{
    Console.WriteLine($"Bill: {(100*5)+(100*7)+(units-200)*10}");
}