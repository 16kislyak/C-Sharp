// Задача 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!); 

if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной день.");
}
else if (num > 7  || num < 1)
{
    Console.WriteLine("Неверный номер.");  
}
else 
{
    Console.WriteLine("Это будний день.");
}
