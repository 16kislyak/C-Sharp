// // создаем таблицу символов

// string[,] table = new string[2, 5];

// // String.Empty - инициализация строк по умолчанию
// // table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// // table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// table[1, 2] = "слово";

// // потребуется цикл в цикле, чтобы распечатать данный массив
// for (int rows = 0; rows < 2; rows ++) //заполняем строки
// {
//     for (int columns = 0; columns < 5; columns++) // заполняем столбцы
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }






// // создаем массив чисел
// // опишем метод, который будет выводить матрицу на экран и заполнять ее числами
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) //заполняем строки, matrix.GetLength(0) 0- кол-во строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // заполняем столбцы, matrix.GetLength(1) 1- кол-во столбцов
//         {
//             Console.Write($" {matr[i, j]} "); // заполняем символы в строке
//         }
//         Console.WriteLine(); // делаем переход на новую строку
//     }
// }

// // метод, который будет заполнять матрицу случайными числами
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) 
//         {
//             matr[i,j] = new Random().Next(1, 10); // [1, 10)
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);






// // создать рисунок

// int[,] pic = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//     {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($" {image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// // метод, который раскрасит изображение
// void FillImage(int row, int col) // аргументы - позиция строки и пикселя, с которого будем начинать закраску
// {
//     if (pic[row, col] == 0) // если пиксельне закрашен
//     {
//         pic[row, col] = 1; // будем красить единичкой
//         FillImage(row - 1, col); // функция вызывает сама себя
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);





// // найти факториал с помощью рекурсии

// double Factorial(int n) // int меняем на double,т.к.нужно увел. объем типа данных (после предела будут отриц. числа)
// {
//     if (n == 1) return 1; // !1 = 1; !0 = 1;
//     else return n * Factorial(n - 1);
// }

// for (int i = 1; i < 20; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }







// вывод чисел Фибоначии

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}