//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("Enter number of lines");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];
RandomArray(matrix);


for (int j = 0; j < matrix.GetLength(1); j++)
{
    int avarage = 0; //специально чтобы округлить, хотя надо бы "double"
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "   ");
}
Console.WriteLine();
PrintArray(matrix);

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
      
        Console.WriteLine("   ");
    }
}
