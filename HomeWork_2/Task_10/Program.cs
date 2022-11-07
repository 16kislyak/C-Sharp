// Задача 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int first = num / 100;
if (first == 0 || first > 9)
{
    Console.WriteLine("Число не трехзначное!");
}
else
{
    int num1 = num / 10;
    int second = num1 - first*10;
    Console.WriteLine($"Вторая цифра: {second}"!);
}


