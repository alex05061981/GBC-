﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double num1X = double.Parse(Console.ReadLine());
double num1Y = double.Parse(Console.ReadLine());
double num1Z = double.Parse(Console.ReadLine());

double num2X = double.Parse(Console.ReadLine());
double num2Y = double.Parse(Console.ReadLine());
double num2Z = double.Parse(Console.ReadLine());

double distantion = Math.Sqrt(Math.Pow((num2X-num1X),2)+Math.Pow((num2Y-num1Y),2)+Math.Pow((num2Z-num1Z),2));
Console.WriteLine($"Расстояние между точками равно {distantion}");