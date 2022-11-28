// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int o, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, o];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                int number = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, number)) {k--; continue;}
                result[i, j, k] = number;
            }
        }
    }
    return result;
}


bool FindElement(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] inArray)
{
    Console.WriteLine($"Массив размером {inArray.GetLength(0)}x{inArray.GetLength(1)}x{inArray.GetLength(2)}");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}x{j}x{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите длину: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите ширину: ");
int width = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту: ");
int height = int.Parse(Console.ReadLine()!);

int[,,] array = GetArray(length, width, height, 10, 99);
PrintArray(array);