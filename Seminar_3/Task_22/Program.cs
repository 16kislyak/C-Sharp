// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

string GetSquare(int N)
{
    string result = "";
    for (int i=1; i<N; i++)
    {
        result += (i*i).ToString()+", ";
    }
    result += (N*N).ToString();
    return result;
}
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

string GetSquare1 = GetSquare(n);
Console.WriteLine($"{GetSquare1}");
