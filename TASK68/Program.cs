//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.Clear();
int m = Numbers("Enter positive number m: ");
int n = Numbers("Enter positive number n: ");

int Akkerman = Function(m, n);
Console.Write($"Akkerman Function  is  {Akkerman} ");


int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
int Function(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Function(m - 1, 1);
  else return Function(m - 1, Function(m, n - 1));
}
