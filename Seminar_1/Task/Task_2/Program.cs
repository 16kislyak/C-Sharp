// Написать программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите номер дня недели: ");

int num = int.Parse(Console.ReadLine()!);

if (num == 1)
    Console.WriteLine("Это понедельник!");
else if (num == 2)
    Console.WriteLine("Это вторник!");
else if (num == 3)
    Console.WriteLine("Это среда!");
else if (num == 4)
    Console.WriteLine("Это четверг!");
else if (num == 5)
    Console.WriteLine("Это пятница!");
else if (num == 6)
    Console.WriteLine("Это суббота!");
else if (num == 7)
    Console.WriteLine("Это воксресенье!");
else
    Console.WriteLine("Введите еще раз");
