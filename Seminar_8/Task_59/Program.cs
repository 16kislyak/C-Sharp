// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.

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

int[,] GetNewArray(int[,] oldArray)
{
    int r = 0; // строка min
    int c = 0; // столбец min
    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        for (int j = 0; j < oldArray.GetLength(1); j++)
        {
            if (oldArray[i, j] < oldArray[r, c]) { r = i; c = j; }
        }
    }
    Console.WriteLine($"{r}, {c}");
    int[,] newArray = new int[oldArray.GetLength(0) - 1, oldArray.GetLength(1) - 1];
    int row1 = 0; int col1 = 0;
    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        if (i == r) {continue;}
        {
            for (int j = 0; j < oldArray.GetLength(1); j++)
            {
                if (j == c) {continue;}
                {
                    newArray[row1, col1] = oldArray[i, j];
                    col1++;
                }
            }
            row1++;  col1 = 0;
        }
    }
    return newArray;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
PrintArray(GetNewArray(array));