//Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

int n = Numbers("Enter quantity of natural numbers:");;
int count = 2;
Show(n, count);
Console.Write(1);

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void Show(int n, int count)
{
  if (count > n) return;
  Show(n, count + 1);

  Console.Write(count + " ");
  
}

