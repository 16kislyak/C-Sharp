// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= rows * columns)
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < columns - 1)
            j++;
        else if (i < j && i + j >= rows - 1)
            i++;
        else if (i >= j && i + j > columns - 1)
            j--;
        else
            i--;
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

Console.Clear();
int[,] array = GetArray(4, 4);
PrintArray(array);

