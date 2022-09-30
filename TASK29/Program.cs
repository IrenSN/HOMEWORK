//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

Console.Clear();

Console.Write("Enter array:");

int array = Convert.ToInt32(Console.ReadLine());

int[] someArray = new int[array];

for (int i = 0; i < someArray.Length; i++)
{
    someArray[i] = new Random().Next(1,100);

    Console.Write(someArray[i] + "/ ");
}

