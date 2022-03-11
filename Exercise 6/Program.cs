// See https://aka.ms/new-console-template for more information
double num1;
Console.WriteLine("This pograme will tell you whether your number is positive, negative or zero.");
num1 = Convert.ToDouble(Console.ReadLine());

if (num1 < 0)
{
    Console.WriteLine("your number is negative");
}
if (num1 > 0)
{
    Console.WriteLine("your number is positive");
}
else (num1 = 0)
{
    Console.WriteLine("your number is zero");
}