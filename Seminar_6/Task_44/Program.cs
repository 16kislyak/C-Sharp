// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int[] Fibonacci(int n)
{
    if(n == 0) return new int[0] {};
    if(n == 1) return new int[1] {0};
    if(n == 2) return new int[2] {0, 1};
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(", ", Fibonacci(N)));



