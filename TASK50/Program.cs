//Задача 50.Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("Enter array's size:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,100));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "   ");
        Console.WriteLine();
}
 
 Console.WriteLine("Enter coordinates of the element:");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());

 if (a>m || b>n)
{
 Console.WriteLine("Not exist:");
 }
 else
 {
 object c = array.GetValue(a,b);

 Console.WriteLine(c);
 }
