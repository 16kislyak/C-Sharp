// Задача 53. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

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
            Console.Write($"{inArray[i, j]} \t"); // \t - табуляция
        }
        Console.WriteLine();
    }
}

int[,] ReplaceRows (int[,] oldArray)
{
    for (int j = 0; j < oldArray.GetLength(1); j++)
    {
        int temp = oldArray[0, j];
        oldArray[0, j] = oldArray[oldArray.GetLength(0) - 1, j];
        oldArray[oldArray.GetLength(0) - 1, j] = temp;
    }
    return oldArray;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
ReplaceRows(array);
Console.WriteLine();
PrintArray(array);
