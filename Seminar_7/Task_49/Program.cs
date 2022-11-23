// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

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

int[,] GetNewArray(int[,] oldArray)
{
    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        for (int j = 0; j < oldArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) oldArray[i, j] = oldArray[i, j] * oldArray[i, j];
        }
    }
    return oldArray;
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

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
GetNewArray(array);
Console.WriteLine();
PrintArray(array);



