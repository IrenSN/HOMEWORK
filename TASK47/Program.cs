//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
Console.Clear();

Console.WriteLine("Number of lines");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[lines, columns];
Random(num);
PrintArray(num);

void Random(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine("");
    }
}