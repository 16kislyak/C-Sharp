//Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void FindNumber(int[] array, int A, int B)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= A && array[i] <=B)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

Console.Clear();
int[] Array = GetArray(123, -250, 250);
Console.WriteLine(String.Join(" ", Array));
FindNumber(Array, 10, 99);