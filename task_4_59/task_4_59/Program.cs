Console.WriteLine("Введите значения сторон треугольника");
int a =Convert.ToInt32(Console.ReadLine());
int  b =Convert.ToInt32(Console.ReadLine());
int c =Convert.ToInt32(Console.ReadLine());
if (a==b && b == c && c ==a)
{
    Console.WriteLine("Равносторонний треугольник");
}
else if ((a==b || a==c || b == c) )
{
    Console.WriteLine("Равнобедренный треугольник");
}