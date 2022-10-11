//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.

Console.Clear();
int m = Numbers("Enter m: ");
int n = Numbers("Enter n: ");
int range = Numbers("Enter number form 0 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sum = Sum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int TemporarySum = Sum(array, i);
  if (sum > TemporarySum)
  {
    sum = TemporarySum;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} - line with minimum sum of the elements");


int Sum(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
     Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine("]");
    Console.WriteLine();
    
  }
}
