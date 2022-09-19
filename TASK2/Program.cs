// Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.Write("Enter first number");

var num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number");

var num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
     Console.WriteLine(num2);
}