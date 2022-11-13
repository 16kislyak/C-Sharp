// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень самостоятельно!

int GetDegree (int a, int b)
{
    int i = 1;
    int result = 1;
    while(i <= b)
    {
        result *=a;
        i++;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
int Degree = GetDegree(A, B);
Console.WriteLine(Degree);
