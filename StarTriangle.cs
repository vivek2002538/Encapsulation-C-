Console.Write("enter rows: ");
int n=Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    for(int j = 1 ; j<=i+1;j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}