// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);
int first = num / 100;
int third = num % 10;
int result = first*10 + third;
Console.WriteLine($"{num} -> {result}");
