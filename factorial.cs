Console.Write("Enter the Number: ");
int n=Convert.ToInt32(Console.ReadLine());
int fact=1;
for(int i = 1; i <= n; i++)
{
    fact*=i;
}
Console.WriteLine(fact);