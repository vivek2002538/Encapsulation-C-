Console.Write("Enter seconds:");
int n=Convert.ToInt32(Console.ReadLine());
int hours=n/3600;
int min=(n%3600)/60;
int sec=(n%3600)%60;
Console.WriteLine($"{hours} h {min} m {sec} s");