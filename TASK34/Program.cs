//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами.Напишите программу, которая покажет
// количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Enter number of array's elements:");
int S = Convert.ToInt32(Console.ReadLine());
int[] N = new int[S];
Random(N);
Console.WriteLine("Array: ");
PrintArray (N);
int counts = 0;
void Random(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
for (int X = 0; X < N.Length; X++)
if (N[X] % 2 == 0)
counts++;

Console.WriteLine($"{counts} of even numbers in array");