Console.WriteLine("Введите значение x");
int x = Convert.ToInt32(Console.ReadLine());
if (Math.Sin(x) >= 0)
{
    double k = Math.Pow(x, 2);
    if (k < x)
    {
        double f = Math.Abs(x);
        Console.WriteLine($"f = {f}");
    }
    else if (k >= x)
    {
        double f = k * x;
        Console.WriteLine($"f = {f}");
    }
}
else if (Math.Sin(x) < 0)
{
    double k = Math.Abs(x);
    if (k < x)
    {
        double f = Math.Abs(x);
        Console.WriteLine($"f = {f}");
    }
    else if (k >= x)
    {
        double f = k * x;
        Console.WriteLine($"f = {f}");
    }
}