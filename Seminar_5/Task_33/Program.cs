// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void FindNumber(int[] array, int N)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == N)
        {
            Console.WriteLine("Да");
            return; // прекращает работу тоже, как и break
        }
    }
    Console.WriteLine("Нет");
}

int[] Array = GetArray(5, -9, 9);
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(" ", Array));
FindNumber(Array, A);