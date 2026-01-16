/ Console.WriteLine("Введите значение x");
Double x = Convert.ToDouble(Console.ReadLine());
if (0.2 <= x && x <= 0.9)
{
    double f = Math.Sin(x);
    Console.WriteLine($" f = {f}");
}
else
{
    double f = 1;
    Console.WriteLine($"f = {f}");
}