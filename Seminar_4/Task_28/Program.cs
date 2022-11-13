// Задача 28. Напишите программу, котораяпринимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetMult(int N)
{
    int count = 1;
    int i = 1;
    while (i <= N)
    {
        count *= i;
        i++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int Mult = GetMult(A);
Console.WriteLine(Mult);