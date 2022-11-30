// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NaturalNumbers(int M, int N)
{
    if (N == M) return N.ToString();
    Console.WriteLine(N);
    return $"{NaturalNumbers(M, N - 1)}, {N}";
}

int[][] data = new int[][]
{
    new int[] {1, 5},
    new int[] {4, 8}
};
foreach (int[] item in data)
{
    Console.WriteLine($"{item[0], 2} -> {NaturalNumbers(item[0], item[1])}");
}
