﻿// Создать программу, которая принимает два числа и определяет, является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num2 * num2 == num1)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}