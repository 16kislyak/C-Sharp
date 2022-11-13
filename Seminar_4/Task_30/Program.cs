// Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

int[] FillArray()
{
    int[] a = new int [8];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 2);
    }
    return a;
}

Console.Clear();
int[] array = FillArray();
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

// void GetArray(int[] collection)
// {
//     for(int i = 0; i < collection.Length; i++)
//     {
//         collection[i] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.Write($"{col[pos]}, ");
//         pos++;
//     }
// }

// Console.Clear();
// int[] array = new int[8];
// GetArray(array);
// PrintArray(array);