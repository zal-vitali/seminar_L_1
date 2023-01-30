// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите последовательно три числа.");
Console.WriteLine("Число 1:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Число 2:");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Число 3:");
int number3 = int.Parse(Console.ReadLine()!);

int mmax = number1;

if (mmax < number2) mmax = number2;
if (mmax < number3) mmax = number3;

Console.Write("max = ");
Console.WriteLine(mmax);