﻿// Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵) 2, 4 -> 16
Console.Clear();
Console.Write("Enter number A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B:");
int B = Convert.ToInt32(Console.ReadLine());
double Newresult = Math.Pow(A,B);
Console.WriteLine(": " + Newresult);