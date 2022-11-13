// Задача 27. Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum (int N)
{
    int sum = 0;
    while(N > 10)
    {
        int remain = N % 10;
        sum += remain;
        N = N / 10;
    }
    if(N < 10)
    {
        sum +=N;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
int Sum = GetSum(A);
Console.WriteLine($"Сумма чисел -> {Sum}");