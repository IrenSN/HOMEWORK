//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

Console.Clear();
int m = Numbers("Enter m: ");
int n = Numbers("Enter n: ");
int range = Numbers("Choose from 0 to   : ");
int[,] matrix = new int[m, n];
CreateArray(matrix);
WriteArray(matrix);

Console.WriteLine($"Now you have array: ");
LinesOfAr(matrix);
WriteArray(matrix);
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
void LinesOfAr(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int s = 0; s < matrix.GetLength(1) - 1; s++)
      {
        if (matrix[i, s] < matrix[i, s + 1])
        {
          int temp = matrix[i, s + 1];
          matrix[i, s + 1] = matrix[i, s];
          matrix[i, s] = temp;
        }
      }
    }
  }
}
int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "   ");
    } 
    Console.WriteLine(); 
  }
}