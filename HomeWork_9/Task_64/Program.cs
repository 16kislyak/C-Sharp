// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    Console.WriteLine(N);
    return $"{N}, {NaturalNumbers(N - 1)}";
}

int[][] data = new int[][]
{
    new int[] {1, 10}
};
foreach (int[] item in data)
{
    Console.WriteLine($"{item[0], 2} -> {NaturalNumbers(item[1])}");
}