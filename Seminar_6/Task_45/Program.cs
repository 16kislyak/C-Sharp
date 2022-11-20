// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    
    return res;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] arrayNew = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", arrayNew));
Console.WriteLine(String.Join(", ", CopyArray(arrayNew)));
