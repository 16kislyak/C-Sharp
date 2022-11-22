// Задача со звездочкой. Напишите программу, которая реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против часовой стрелки.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i,j] = new Random().Next(1, 10); // [1, 10)
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] UnwindArray(int[,] origArray)
{
    int line = origArray.GetLength(0);
    int column = origArray.GetLength(1);
    int[] newArray = new int[line * column];
    int i = 0;
    int line1 = 0;
    int column1 = 0;
    while(i < newArray.Length)
    {
        for (int k = 0; k < column; k++)
        {
            newArray[i] = origArray[line-1, k];
            i++;   
        }
    
        for (int l = line - 1; l >= 0; l--)
        {
            newArray[i] = origArray[l, column-1];
            i++; 
        }

        for (int m = column - 1; m >= 0; m--)
        {
            newArray[i] = origArray[0 + line1, m];
            i++;
        }

        for (int n = 0; n < line - 1; n++)
        {
            newArray[i] = origArray[n, 0 + column1];
            i++;
        }
        column1++;
        line1++;
        line--;
        column--;
    }
    return newArray;
}

Console.Clear();
Console.Write("Введите количество строк: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int y = int.Parse(Console.ReadLine()!);

int[,] randomArray = new int[x, y];
FillArray(randomArray);
PrintArray(randomArray);
UnwindArray(randomArray);
Console.Write(String.Join(", ", randomArray));





