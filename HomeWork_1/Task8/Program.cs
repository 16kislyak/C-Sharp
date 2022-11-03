// Задача 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int count = 1;
while (count <= N)
{
    int div = count % 2;
    if (div == 0) 
    {
        Console.Write($"{count}, ");
    }
     count +=1;
}