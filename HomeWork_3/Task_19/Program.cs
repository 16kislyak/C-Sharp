// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

string Palindrome(int A)
{
    if (A < 10000 || A > 99999)
    {
        return "Число не пятизначное!";
    }
    else
    {
        int first = A/10000;
        int second = A/1000-first*10;
        int third = A/100-first*100-second*10;
        int fourth = A/10-first*1000-second*100-third*10;
        int fifth = A % 10;
        if (first == fifth && second == fourth)
        {
            return ("да");
        }
        else
        {
            return ("нет");  
        }
    }  
}

Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);

string PalindromeMain = Palindrome(a);
Console.WriteLine($"{a} -> {PalindromeMain}");

