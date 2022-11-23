// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве.
// Программа должна возвращать значение позиции (номер строки и столбца) этого элемента
// или же указание, что такого элемента нет.

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

void SearchNumber(int[,] origArray, int num)
{
    for (int i = 0; i < origArray.GetLength(0); i++)
    {
        for (int j = 0; j < origArray.GetLength(1); j++)
        {
            if (origArray[i, j] == num)
            {
                Console.WriteLine($"Позиция искомого числа: {i}, {j}");
                return;
            }
            else if (i == origArray.GetLength(0) - 1 && j == origArray.GetLength(1) - 1)
            {
                Console.WriteLine($"Число {num} не найдено");
            }
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);

Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);

SearchNumber(array, number);


