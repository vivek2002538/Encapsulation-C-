using System;
class AvgMarks
{
    public static void Main(string[] args)
    {
        int n=3;
        int sum=0;
        int count=0;
        for(int i = 0; i < n; i++)
        {
            Console.Write("enter marks");
            int s1=(Convert.ToInt32(Console.ReadLine()));
            sum+=s1;
            count++;
        }    
        double average=(double)sum/(count);
        Console.WriteLine($"Average: {average:F3}");
    }
}