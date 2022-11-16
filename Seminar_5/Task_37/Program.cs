// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int[] MultNumber(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0)
    {
        size++;
    }
    int[] result = new int [size];

    for(int i = 0; i < (array.Length / 2); i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if(array.Length % 2 !=0)
    {
        result[size-1] = array[array.Length / 2];
    }
    return result;
}

Console.Clear();
int[] Array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", Array));
int[] Array2 = MultNumber(Array);
Console.WriteLine(String.Join(" ", Array2));