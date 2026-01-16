Console.WriteLine("Введите значение x");
Double x = Convert.ToDouble(Console.ReadLine());
if (-2.4 <= x && x <= 5.7)
{
    double f = Math.Pow(x, 2);
    Console.WriteLine($" f = {f}");
}
else
{
    double f = 4;
    Console.WriteLine($"f = {f}");
}