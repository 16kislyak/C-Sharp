// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька.
// Реализовать невозрастающую сторировку.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] GetSortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) 
    {
        for (int j = array.Length - 1; j > i; j--)// внутренний цикл прохода
        {
            if (array[j - 1] < array[j])
            {
                int s = array[j - 1];
                array[j - 1] = array[j];
                array[j] = s;
            }
        }
    }
    return array;
}

Console.Clear();
int[] Array = GetArray(5, -5, 5);
Console.Write("[");
Console.Write(String.Join(", ", Array));
Console.WriteLine("]");
GetSortArray(Array);
Console.Write("[");
Console.Write(String.Join(", ", Array));
Console.WriteLine("]");