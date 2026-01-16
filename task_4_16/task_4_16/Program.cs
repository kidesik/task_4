Console.WriteLine("Введите коэффициенты a,b,c квадратного уравнения ax2 + bx + c = 0, a не = 0");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a != 0)
{
    double d = Math.Pow(b, 2) - 4 * a * c;
    if (d < 0)
    {
        Console.WriteLine("нет действительных корней");
    }
    else if (d > 0)
    {
        Double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        Double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"Корень 1 равен {x1}, второй корень равен {x2}");
    }
    else
    {
        Double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"Корень равен {x1}");
    }
}
