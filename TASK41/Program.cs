// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Please, enter your figuers using gap: ");
int[] numbers = N (Console.ReadLine());
int s = 0;

for (int i = 0; i< numbers.Length; i++)
{
{
    if (numbers[i] > 0)
    s++;       
}
}
Console.WriteLine($"Numbers of figures above 0 is: = {s}");  

int[] N (String input)
{
int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string X = "";
        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            X += input [i].ToString();
            i++;
        }
        else
        {
            X += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(X);
        index++;
    }
    return numbers;
}
