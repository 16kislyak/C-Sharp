// Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetAmount(int A)
{
    int count = 0;
    while (A!= 0)
    {
        A = A / 10;
        count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int Amount = GetAmount(N);
Console.WriteLine(Amount);
