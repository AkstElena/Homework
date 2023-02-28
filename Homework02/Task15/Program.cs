﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, соответствующую дню недели");

int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 6)
{
  Console.WriteLine("День не является выходным");
}
else if (day == 6 || day == 7)
{
  Console.WriteLine("День является выходным");
}
else Console.WriteLine("Такой цифры для дня недели не существует. Введите корретное значение");