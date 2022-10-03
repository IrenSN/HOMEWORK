//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Enter array's size:");
int S = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double [S];
RandomNum(numbers);
double max = Int32.MaxValue;
double min = Int32.MinValue;
for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}

Console.WriteLine($"Difference between Max&Min= {max - min}");

void RandomNum(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
