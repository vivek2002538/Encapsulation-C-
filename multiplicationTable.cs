Console.Write("enter the table: ");
int table=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{table}x{i}={table*i}");
}