// Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        res[i] = maxValue - random.Next(maxValue - minValue) + random.NextDouble(); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write($"{res[i]:F2}, "); // - :F2 - количество знаков после запятой
    }
    return res;
}

double FindMax(double[] array1)
{
    double max = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] >= max)
        {
            max = array1[i];
        }
    }
    return max;
}

double FindMin(double[] array2)
{
    double min = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] <= min)
        {
            min = array2[i];
        }
    }
    return min;
}

Console.Clear();
double[] Array = GetArray(4, -9, 9);
FindMax(Array);
FindMin(Array);
Console.WriteLine("");
Console.WriteLine($"Разница между max и min составляет: {(FindMax(Array) - FindMin(Array)):F2}");