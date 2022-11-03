// Задача 6. Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int div = num % 2;
if (div == 0) 
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число нечетное");
}
