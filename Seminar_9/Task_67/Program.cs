// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumDigits(int number)
{
    if (number == 0) {return 0;}
    int up = number / 10;
    int down = number % 10;
    return down + SumDigits(up);
}

Console.WriteLine("Введите число: ");
int a =  int.Parse(Console.ReadLine()!);
int b = SumDigits(a);
Console.WriteLine(b);