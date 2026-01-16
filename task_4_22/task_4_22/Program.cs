Console.WriteLine("Введите значение m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n  = Convert.ToInt32(Console.ReadLine());
if (m % n == 0)
{
    Console.WriteLine((m / n));
}
else
{
    Console.WriteLine("m на n нацело не делится");
}