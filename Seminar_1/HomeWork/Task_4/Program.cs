// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);

int max = 0;

if (num1 > num2)
{
    max = num1;
}
else 
{
    max = num2;
}

if (num3 > max)
{
   max = num3;
    Console.WriteLine($"Максимальное число {max}"); 
}
else
{
    Console.WriteLine($"Максимальное число {max}");
} 
    
