//Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t"); // \t - табуляция
        }
        Console.WriteLine();
    }
}

int[] OneRowArray(int[,] twoArray)
{
    int[] oneArray = new int[twoArray.GetLength(0) * twoArray.GetLength(1)];
    int count = 0;
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            oneArray[count] = twoArray[i, j];
            count++;
        }
    }
    return oneArray;
}

int[] GetSortArray(int[] oneArray)
{
    for (int i = 0; i < oneArray.Length - 1; i++)
    {
        for (int j = oneArray.Length - 1; j > i; j--)
        {
            if (oneArray[j - 1] > oneArray[j])
            {
                int s = oneArray[j - 1];
                oneArray[j - 1] = oneArray[j];
                oneArray[j] = s;
            }
        }
    }
    return oneArray;
}

void FrequencyDictionary(int[] array1)
{
    int number;
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        number = array1[i];
        if (i != 0 && number == array1[i - 1]);
        else
        {
            for (int j = 0; j < array1.Length; j++)
            {
                if (number == array1[j]) count++;
            }
            Console.WriteLine($"{number} встречается {count} раз(а)");
            count = 0;
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
int[] newArray = OneRowArray(array);
GetSortArray(newArray);
Console.WriteLine(String.Join(", ", newArray));
FrequencyDictionary(newArray);