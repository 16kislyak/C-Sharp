// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool ChekTriangle(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int C = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Треугольник со сторонами {A} {B} {C} "+(ChekTriangle(A, B, C)?"является":"не является") +" треугольником");