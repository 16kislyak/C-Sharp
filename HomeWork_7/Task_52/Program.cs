﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] initArray)
{
    for (int j = 0; j < initArray.GetLength(1); j++) // столбцы
    {
        int sum = 0;
        for (int i = 0; i < initArray.GetLength(0); i++) // строки
        {
            sum += initArray[i, j];
        }
        double average = (double) sum / initArray.GetLength(0);
        Console.Write($"{average} \t");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine();
AverageColumn(array);
