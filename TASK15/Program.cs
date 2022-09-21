// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели,и проверяет, является ли этот день выходным.
Console.WriteLine("Введите порядковый номер дня недели");

int DayN = Convert.ToInt32(Console.ReadLine());

void Checking (int DayN) {
  if (DayN == 6 || DayN == 7) {
  Console.WriteLine("(Да,Выходной)");
  }
  else if (DayN < 1 || DayN> 7) {
    Console.WriteLine("Ошибка");
  }
  else Console.WriteLine("(Нет, не выходной)");
}
Checking(DayN);