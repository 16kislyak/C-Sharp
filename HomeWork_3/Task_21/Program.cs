// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

double GetLength(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(X2-X1, 2)+Math.Pow(Y2-Y1, 2)+Math.Pow(Z2-Z1, 2)), 2);
    return result;
}

Console.Clear();
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double GetLength1 = GetLength(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"{GetLength1}");
