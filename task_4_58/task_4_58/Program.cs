Console.WriteLine("Введите три вещественных числа");
int a = Convert.ToInt32(Console.ReadLine());
int  b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if  (a == b || a== c|| c== b)
{
    Console.WriteLine("Да, есть равная пара");
}
else
{
    Console.WriteLine("Нет, все числа разные");
}