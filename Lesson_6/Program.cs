// Необходимо увеличить координаты в 2 раза.

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "") // меняем ( на пробел
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ") // разделителем будет пробел
                .Select(item => item.Split(',')) // выборка элементов с учетом разделителя - ,
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e=> e.x %2 == 0) // пары, в которых первая координата четная
                .Select(point => (point.x * 10, point.y + 10))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
