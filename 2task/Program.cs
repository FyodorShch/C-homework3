/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Введите координаты точки А:");
double ax = Convert.ToInt32(Console.ReadLine());
double ay = Convert.ToInt32(Console.ReadLine());
double az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
double bx = Convert.ToInt32(Console.ReadLine());
double by = Convert.ToInt32(Console.ReadLine());
double bz = Convert.ToInt32(Console.ReadLine());
double distance;
double x = Math.Pow(bx - ax, 2);
double y = Math.Pow(by - ay, 2);
double z = Math.Pow(bz - az, 2);
distance = Math.Sqrt(x + y + z);
Console.WriteLine($"Расстояние между точками равно {distance}");