Console.WriteLine("Введите размеры кирпича с ребрами а, b, c и размеры прямоугольного отверстия со сторонами х и у");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if ((a <= x && b <= y) || (a <= y && b <= x) || (a <= x && c <= y) || (a <= y && c <= x) || (b <= x && c <= y) || (b <= y && c <= x))
{
    Console.WriteLine("Кирпич пройдет");
}
else
{
    Console.WriteLine("Кирпич не пройдет");
}
