//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

Console.WriteLine("Enter array's size:");
int S = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [S];
RandomNum(numbers);
Console.WriteLine("Array is:");
PrintArray(numbers);
int summ = 0;

for (int x = 0; x < numbers.Length; x+=2)
summ = summ + numbers[x];
Console.WriteLine($"Sum of honest numbers: = {summ}");
void RandomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
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

