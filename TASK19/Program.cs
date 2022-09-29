// Задача 19
//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

Console.Clear();

Console. WriteLine("Enter five-digit number");

string number = Console.ReadLine();

void Verify(string number)
{
    if (number[0]==number[4] || number[1]== number[3])
  {
    Console.WriteLine($"Your number {number} is Palindrom");
  }
  else Console.WriteLine($"Your number {number} is not a palindrom");
}
if (number.Length== 5)
{
  Verify(number);
}
else Console.WriteLine($"Enter correct number");


