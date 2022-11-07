// Задача 13. Напишите программу, которая выводит третью цифру (слева направо) заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (num >= 1000)
    {
        num /= 10;
    }
    int third = num % 10;
    Console.WriteLine(third);
}

// ВТОРОЙ ВАРИАНТ

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// int digit = num / 100;
// if (digit == 0)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else
// {
//     string numline = num.ToString();
//     Console.WriteLine($"Третья цифра: {numline[2]}"!); 
// }