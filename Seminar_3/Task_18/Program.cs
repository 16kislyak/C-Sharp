//Задача 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string GetInfo(int x)
{
    if (x == 1)
    {
        return ("x > 0, y > 0");
    }
    else if (x == 2)
    {
        return ("x < 0, y > 0");
    }
    else if (x == 3)
    {
        return ("x < 0, y < 0");
    }
    else
    {
        return ("x > 0, y < 0");
    }
}

Console.Clear();
int X = int.Parse(Console.ReadLine()!);

string GetInfo1 = GetInfo(X);
Console.WriteLine($"{GetInfo1}");

