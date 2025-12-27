Console.WriteLine("Введите вещественное число через .");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (a< b)
{
    Console.WriteLine($"Большее число: {b} \nМеньшее число: {a}");
}
if  (b< a)
{
    Console.WriteLine($"Большее число: {a} \nМеньшее число: {b}"); 
}