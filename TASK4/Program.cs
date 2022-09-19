// Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Enter first number");

var num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number");

var num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number");

var num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);