Console.WriteLine("Введите координаты начального поля фигуры (от 1 до 8):");
Console.Write("Вертикаль (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Горизонталь (b): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nВведите координаты целевого поля (c, d):");
Console.Write("Вертикаль (c): ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Горизонталь (d): ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nНачальное поле: ({a}, {b}), Целевое поле: ({c}, {d})");
if ((a == c || b == d))
{
    Console.WriteLine($"а) Ладья угрожает полю ({c}, {d})");
}
else
{
    Console.WriteLine($"а) Ладья не угрожает полю ({c}, {d})");
}
if (Math.Abs(a - c) == Math.Abs(b - d))
{
    Console.WriteLine($"б) Слон угрожает полю ({c}, {d})");
}
else
{
    Console.WriteLine($"б) Слон не угрожает полю ({c}, {d})");
}
if((Math.Abs(a - c) <= 1 && Math.Abs(b - d) <= 1 && !(a == c && b == d)))
{
    Console.WriteLine($"в) Король может попасть на поле ({c}, {d}) одним ходом");
}
else
{
    Console.WriteLine($"в) Король не может попасть на поле ({c}, {d}) одним ходом");
}
if (a == c || b == d || Math.Abs(a - c) == Math.Abs(b - d))
{
    Console.WriteLine($"г) Ферзь угрожает полю ({c}, {d})");
}
else
{
    Console.WriteLine($"г) Ферзь не угрожает полю ({c}, {d})");
}
bool whitePawnNormal = (a == c && d == b + 1);
bool whitePawnCapture = (Math.Abs(a - c) == 1 && d == b + 1);
Console.WriteLine($"д) Белая пешка может попасть на ({c}, {d}) при обычном ходе: **{whitePawnNormal}**, при взятии: **{whitePawnCapture}**");
bool blackPawnNormal = (a == c && d == b - 1);
bool blackPawnCapture = (Math.Abs(a - c) == 1 && d == b - 1);
Console.WriteLine($"е) Черная пешка может попасть на ({c}, {d}) при обычном ходе: **{blackPawnNormal}**, при взятии: **{blackPawnCapture}**");
if ((Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2) || (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1))
{
    Console.WriteLine($"ж) Конь угрожает полю ({c}, {d})");
}
else
{
    Console.WriteLine($"ж) Конь не угрожает полю ({c}, {d})");
}