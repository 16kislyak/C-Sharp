// Задача “со звездочкой”. Напишите функцию, которая принимает одно число - высоту елочки
// и рисует ее в консоли звездочками.

string GetSpruce(int h)
{
    int i = 1;
    string Star = "*";
    while(i <= h)
    {
        int centerX = (Console.WindowWidth / 2) - (Star.Length / 2);
        Console.SetCursorPosition(centerX, i);
        Console.WriteLine(Star);
        Star += "**";
        i++;
    }
    return Star;
}

Console.Clear();
Console.Write("Введите высоту ёлки: ");
int H = int.Parse(Console.ReadLine()!);
string Spruce = GetSpruce(H);
