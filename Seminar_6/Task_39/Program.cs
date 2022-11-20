// Задача 39. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    
    return res;
}

void ReverseArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}

int[] ReverseArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i <inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

int[] array = GetArray(5, -10, 10);
Console.WriteLine(string.Join(", ", array));
ReverseArray1(array);
Console.WriteLine(string.Join(", ", array));
int[] res = ReverseArray2(array);
Console.WriteLine(string.Join(", ", res));