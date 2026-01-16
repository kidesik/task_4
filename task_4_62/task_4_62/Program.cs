Console.WriteLine("Введите стороны первого прямоугольника(a,b). а затем второго (c,d)");
int a = Convert.ToInt32(Console.ReadLine());
int  b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
if ((a <= c && b <= d) || (a <= d && b <= c))
{
    Console.WriteLine("Можно вместить");
}
else
{
    Console.WriteLine("Нельзя вместить");
}