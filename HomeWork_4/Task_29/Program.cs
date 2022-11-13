// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray()
{
    int[] a = new int [8];
    Console.WriteLine("Задайте числа массива: ");
    for (int i = 0; i < a.Length; i++)
    {
        a [i] = int.Parse(Console.ReadLine()!);
    }
    return a;
}

Console.Clear();
int[] array = FillArray();
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");