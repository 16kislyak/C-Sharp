// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ReplaceRowsColumn (int[,] oldArray)
{
    int[,] newArray = new int[oldArray.GetLength(0), oldArray.GetLength(1)];
    if(oldArray.GetLength(0) == oldArray.GetLength(1))
    {
        for (int i = 0; i < oldArray.GetLength(0); i++)
        {
            for (int j = 0; j < oldArray.GetLength(1); j++)
            {
                newArray[i, j] = oldArray[j, i];    
            } 
        }
        return newArray;
    }
    else
    {
        Console.WriteLine("Замена невозможна.");
        return oldArray;
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(ReplaceRowsColumn(array));
