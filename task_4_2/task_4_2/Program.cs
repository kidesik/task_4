Console.WriteLine("Введите значение x");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
    double y = Math.Pow(Math.Sin(x),2);
    Console.WriteLine($"y = {y}");
}
else
{
    double y =1 - 2 * Math.Sin(Math.Pow(x,2));
    Console.WriteLine($"y = {y}");
}