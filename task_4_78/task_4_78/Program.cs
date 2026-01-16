Console.WriteLine("Введите координаты первого поля (от 1 до 8):");
Console.Write("Вертикаль (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Горизонталь (b): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nВведите координаты второго поля (от 1 до 8):");
Console.Write("Вертикаль (c): ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Горизонталь (d): ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nПервое поле: ({a}, {b}), Второе поле: ({c}, {d})");

if (((a + b) % 2) == ((c + d) % 2))
{
    Console.WriteLine("Поля **одного цвета**.");
}
else
{
    Console.WriteLine("Поля **разных цветов**.");
}