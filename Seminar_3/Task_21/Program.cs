// // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и
// // находит расстояние между ними в 2D пространстве.

// double GetLength(double X1, double Y1, double X2, double Y2)
// {
//     double result = Math.Round(Math.Sqrt(Math.Pow(X1-X2, 2)+Math.Pow(Y1-Y2, 2)), 2);
//     return result;
// }

// Console.Clear();
// Console.Write("X1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("X2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Y2: ");
// int y2 = int.Parse(Console.ReadLine());

// double GetLength1 = GetLength(x1, y1, x2, y2);
// Console.WriteLine($"{GetLength1}");

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве. (БЕЗ ФУНКЦИИ Math.Round - округление до заданного кол-ва знаков)

double GetLength(double X1, double Y1, double X2, double Y2)
{
    double result = Math.Sqrt(Math.Pow(X1-X2, 2)+Math.Pow(Y1-Y2, 2));
    return result;
}

Console.Clear();
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine()!);

double GetLength1 = GetLength(x1, y1, x2, y2);
Console.WriteLine($"{GetLength1:f2}");
