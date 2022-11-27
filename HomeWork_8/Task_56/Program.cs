// Задача 56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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



void LineMinAmount(int[,] oneArray)
{
    int sum = 0;
    int line = 0;
    for (int i = 0; i < oneArray.GetLength(0); i++)
    {
        int amount = 0;
        for (int j = 0; j < oneArray.GetLength(1); j++)
        {
            amount += oneArray[i, j];
        }
        if (sum == 0 || amount < sum)
        {
            sum = amount;
            line = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {line + 1} строке");
}


Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine();
LineMinAmount(array);