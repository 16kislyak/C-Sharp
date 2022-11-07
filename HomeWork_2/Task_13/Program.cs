// Задача 13. Напишите программу, которая выводит третью цифру (слева направо) заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int digit = num / 100;
if (digit == 0)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    string numline = num.ToString();
    Console.WriteLine($"Третья цифра: {numline[2]}"!); 
}