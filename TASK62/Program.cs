//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear();
int m = 4;
int[,] Matrix = new int[m, m];

int temp = 1;
int y = 0;
int x = 0;
while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[y, x] = temp;
  temp++;
  if (y <= x + 1 && y + x < Matrix.GetLength(1) - 1)
    x++;
  else if (y < x && y + x >= Matrix.GetLength(0) - 1)
    y++;
  else if (y >= x && y + x > Matrix.GetLength(1) - 1)
    x--;
  else 
    y--;
}
WriteArray(Matrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}