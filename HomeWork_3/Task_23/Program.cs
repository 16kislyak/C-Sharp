// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string GetCube(int N)
{
    string result = "";
    for (int i=1; i<N; i++)
    {
        result += (i*i*i).ToString()+", ";
    }
    result += (N*N*N).ToString();
    return result;
}
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

string GetCube1 = GetCube(n);
Console.WriteLine($"{GetCube1}");