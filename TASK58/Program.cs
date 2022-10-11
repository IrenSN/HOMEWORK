//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine($"Enter two matrix(the number of lines are equal):");
int m = InputNumbers("Enter the number of 1st matrix lines: ");
int n = InputNumbers("Enter the number of columns of 1st matrix(number of lines of the 2nd): ");
int p = InputNumbers("Enter the number of 1st matrix columns: ");
int range = InputNumbers("Enter random number from 0 to ");

int[,] Mfirst = new int[m, n];
CreateArray(Mfirst);
Console.WriteLine($"1st mtrix:");
WriteArray(Mfirst);

int[,] Msecond = new int[n, p];
CreateArray(Msecond);
Console.WriteLine($"2nd matrix:");
WriteArray(Msecond);

int[,] MultipleMatrix = new int[m,p];

TotalMatrix(Mfirst, Msecond, MultipleMatrix);
Console.WriteLine($"Multiple matrix:");
WriteArray(MultipleMatrix);

void TotalMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
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
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
