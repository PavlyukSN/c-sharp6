﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения первой прямой.");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значения первой прямой.");
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2) {Console.WriteLine("Линии параллельны");}
else {
double x = ((b2 - b1) / (k1 - k2));
double y1 = (k1 * x + b1);
double y2 = (k2 * x + b2);
if (y1 == y2) {
Console.WriteLine($"Координаты точки пересечения ({x}; {y1})"); }
else {Console.WriteLine("Не удалось найти точки пересечения");}
}
