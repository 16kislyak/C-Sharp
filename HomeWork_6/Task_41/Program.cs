// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArray(int size)
{
    int[] collectNum = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        collectNum[i] = int.Parse(Console.ReadLine()!);
    }
    return collectNum;
}

int FindPosNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите общее количество чисел: ");
int M = int.Parse(Console.ReadLine()!);
int[] newArray = GetArray(M);
Console.Write(String.Join(", ", newArray));
Console.WriteLine($" --> {FindPosNum(newArray)}");
