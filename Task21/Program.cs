﻿// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("ВВедите координату Х1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите координату Х2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите координату y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите координату y2");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите координату z1");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите координату z2");
int z2 = int.Parse(Console.ReadLine()!);

double sqrX = Math.Pow((x1 - x2), 2);
double sqrY = Math.Pow((y1 - y2), 2);
double sqrZ = Math.Pow((z1 - z2), 2);
double answer = Math.Round(Math.Sqrt(sqrX + sqrY + sqrZ), 3);
Console.WriteLine($"Расстояние между точками {answer} ");