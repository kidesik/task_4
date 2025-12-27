Console.WriteLine("Hello, World!");
int r = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
double s_s = Math.PI * r;
double S_a = Math.Pow(a, 2);
if (s_s > S_a)
{
    Console.WriteLine("Площадь круга больше");
}
else if (s_s < S_a)
{
    Console.WriteLine("площадь квадрата больше");
}
else
{
    Console.WriteLine("площади равны");
}
