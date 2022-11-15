// Задача 32. Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void GetOpposite(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    Console.WriteLine(String.Join(" ", array));
}
Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение: ");
int MinVal = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение: ");
int MaxVal = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(length, MinVal, MaxVal);
Console.WriteLine(String.Join(" ", Array));
GetOpposite(Array);