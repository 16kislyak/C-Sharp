// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2) 
{
    Console.WriteLine($"Большее {num1}, меньшее {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Большее {num2}, меньшее {num1}");
}
else
{
    Console.WriteLine("Числа равны");
}