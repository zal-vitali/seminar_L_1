﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число для его проверки на чётность:");
int number = int.Parse(Console.ReadLine()!);

string report = "Нет";

if (number%2 == 0) report = "Да";

Console.WriteLine(report);