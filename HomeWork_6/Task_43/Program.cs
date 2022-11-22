//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int[] GetArray(int size)
{
    int[] collectNum = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        collectNum[i] = int.Parse(Console.ReadLine()!);
    }
    return collectNum;
}

void FindCrossing(int[] array1, int[] array2)
{
    if (array1[0] == array2[0]) Console.WriteLine("Прямые параллельны");
    else if (array1[0] == array2[0] && array1[1] == array2[1]) Console.WriteLine("Прямые совпадают");
    else
    {
        double x = (double)(array2[1] - array1[1]) / (array1[0] - array2[0]);
        double y = (double)((array1[0] * x) + array1[1]);
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}, {y})");
    }
}

Console.Clear();
Console.Write("Введите кол-во координат: ");
int amount = int.Parse(Console.ReadLine()!);

int[] Line1 = GetArray(amount); // k1, b1

int[] Line2 = GetArray(amount); // k2, b2

FindCrossing(Line1, Line2);