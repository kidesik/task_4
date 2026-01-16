Console.WriteLine("Введите коэффициенты a,b,c квадратного уравнения ax2 + bx + c = 0, a не = 0");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int  c = Convert.ToInt32(Console.ReadLine());
if (a != 0) {
    double d = Math.Pow(b, 2) - 4 * a * c;
    if (d < 0)
    {
        Console.WriteLine("нет действительных корней");
    }
    else if (d > 0)
    {
        Console.WriteLine("два действительных корня");
    }
    else
    {
        Console.WriteLine("есть один действительный корень");
    }
}
