// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    Console.WriteLine(N);
    return $"{NaturalNumbers(N - 1)}, {N}";
}

int[][] data = new int[][]
{
    new int[] {1, 5},
    new int[] {1, 8}
};
foreach (int[] item in data)
{
    Console.WriteLine($"{item[0], 2} -> {NaturalNumbers(item[1])}");
}