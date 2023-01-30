//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите последовательно два числа.");
Console.WriteLine("Число 1:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Число 2:");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 < number2)
{
    Console.Write("max = ");
    Console.WriteLine(number2);
}
else if (number1 > number2)
{
    Console.Write("max = ");
    Console.WriteLine(number1);
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
