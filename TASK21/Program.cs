// Задача 21: Напишите программу, которая принимает 
 //на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Enter First point coordinates:");
double [] x = new double[3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("Enter Second point coordinates:");
double [] y = new double[3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

double oper = Math.Pow((y[0]-x[0]),3) + Math.Pow((y[1]-x[1]),3) + Math.Pow((y[2]-x[2]),3);
Console.WriteLine(Math.Sqrt(oper));