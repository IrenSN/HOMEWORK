// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.


Console.Clear();

int m = Numbers("Enter natural number m: ");
int n = Numbers("Enter natural number n: ");
int temp = m;

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

if (m > n) 
{
  m = n; 
  n = temp;
}

Print(m, n, temp=0);

void Print(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"The Sum is= {sum} ");
    return;
  }
  Print(m, n - 1, sum);
}

