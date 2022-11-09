// Вид 1 (ничего не принимают, ничего не возвращают)

void Method1()
{
    Console.WriteLine("Автор: Кисляк Марина.");
}
Method1();


// Вид 2 (что-то принимают, ничего не возвращают)

void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21 (string msg, int count)
{
    int i=0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4);
Method21(count: 4, msg: "Новый текст");



// Вид 3 (ничего не принимают, что-то возвращают)

int Method3 ()
{
    return DataTime.Now.Year;
}
int Year = Method3();
Console.WriteLine (Year);


// Вид 4 (что-то принимают, что-то возвращают)

int Method4 (int count, char text);
{
    int i = 0;
    string result = string.Empty; // пустая строка (string result = "";)
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


// ЦИКЛ FOR
int Method4 (int count, char text);
{
    string result = string.Empty; // пустая строка (string result = "";)
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


// ЦИКЛ В ЦИКЛЕ (вывод таблицы умножения на экран)

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}