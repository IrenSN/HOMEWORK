// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите сюда любое число, чтобы узнать его третью цифру:");

int Number = Convert.ToInt32(Console.ReadLine());
string Text = Convert.ToString(Number);
if (Text.Length > 2){
  Console.WriteLine("третья цифра -> " + Text[2]);
}
else {
  Console.WriteLine("-> третьей цифры в этом числе нет");
}
