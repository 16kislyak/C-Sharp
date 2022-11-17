// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void FindSumUneven(int[] array)
{
    int Sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            Sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {Sum}");
}

Console.Clear();
int[] Array = GetArray(10, -10, 10);
Console.Write("[");
Console.Write(String.Join(", ", Array));
Console.WriteLine("]");
FindSumUneven(Array);