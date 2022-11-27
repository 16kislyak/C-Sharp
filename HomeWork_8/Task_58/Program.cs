// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// https://www.math10.com/ru/vysshaya-matematika/matrix/umnozhenie-matric.html

int[,] GetArray(int minValue, int maxValue)
{
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int cols = int.Parse(Console.ReadLine()!);
    int[,] result = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
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



int[,] MatrixMultiplication(int[,] oneArray, int[,] twoArray)
{
    int[,] newArray = new int[oneArray.GetLength(0), twoArray.GetLength(1)];

    for (int i = 0; i < oneArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            newArray[i, j] = 0;
            for (int k = 0; k < oneArray.GetLength(1); k++)
            {
                newArray[i, j] += oneArray[i, k] * twoArray[k, j];
            }
        }
    }
    return newArray;
}


Console.Clear();
int[,] array1 = GetArray(0, 5);
PrintArray(array1);
int[,] array2 = GetArray(0, 5);
PrintArray(array2);
if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
}
else
{
    Console.WriteLine();
    PrintArray(MatrixMultiplication(array1, array2));
}