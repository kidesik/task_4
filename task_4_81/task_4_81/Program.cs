Console.WriteLine("Введите размер сторон");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if ((a + b > c) && (a + c > b) && (c + b > a))
{
    Console.WriteLine("Треугольник существует");
    if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) && (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2)) && (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)))
    {
        Console.WriteLine("треугольник является прямоугольным");
    }
    else if ((Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2)) && (Math.Pow(b, 2) + Math.Pow(c, 2) > Math.Pow(a, 2)) && (Math.Pow(a, 2) + Math.Pow(c, 2) > Math.Pow(b, 2)))
    {
        Console.WriteLine("треугольник остроугольный.");
    }
    else if ((Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2)) && (Math.Pow(b, 2) + Math.Pow(c, 2) < Math.Pow(a, 2)) && (Math.Pow(a, 2) + Math.Pow(c, 2) < Math.Pow(b, 2)))
    {
        Console.WriteLine("треугольник тупоугольный.");
    }
    if (a == b && b == c)
    {
        Console.WriteLine("**равносторонний**.");
    }
    else if (a == b || a == c || b == c)
    {
        Console.WriteLine("**равнобедренный**.");
    }
    else
    {
        Console.WriteLine("**разносторонний**.");
    }
}
else
{
    Console.WriteLine("Треугольник не существует");
}
