// Задача 54. Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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



int[,] GetSortArray(int[,] oneArray)
{
    for (int i = 0; i < oneArray.GetLength(0); i++)
    {
        for (int j = 0; j < oneArray.GetLength(1); j++)
        {
            for (int k = 0; k < oneArray.GetLength(1) - 1; k++)
            {
                if (oneArray[i, k] < oneArray[i, k + 1])
                {
                    int s = oneArray[i, k + 1];
                    oneArray[i, k + 1] = oneArray[i, k];
                    oneArray[i, k] = s;
                }
            }

        }
    }
    return oneArray;
}


Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(GetSortArray(array));
