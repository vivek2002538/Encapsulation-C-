Console.Write("Enter a number: ");
string input=Console.ReadLine();
if (int.TryParse(input,out int number))
{
    Console.WriteLine($"you entered :{number}");
}
else
{
    Console.WriteLine($"This is not valid Number");
}