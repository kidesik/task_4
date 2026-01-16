Console.WriteLine("Введите вещественные числа a, b, c (а не = 0)");
int a = Convert.ToInt32(Console.ReadLine());
int  b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
double d = Math.Pow(b, 2) - 4 * a * c;
if (d > 0)
{
    double x_1 = (-b + Math.Sqrt(d))/(2*a) ;
    double x_2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"корни уравнения равны x_1 = {x_1}\nx_2 = {x_2}");
}
else if (d == 0)
{
     double x = - b/(2*a) ;
    Console.WriteLine($"корень уравнения равен x = {x}");
}
else
{
    Console.WriteLine("действительных корней нет.");
}