Console.WriteLine("Hello, World!");
double s_circle = Convert.ToDouble(Console.ReadLine());
double s_triangle  = Convert.ToDouble(Console.ReadLine());
double r_circle = Math.Sqrt(s_circle/Math.PI);
double r_triangle = Math.Sqrt((s_triangle * 4) /(3*Math.Sqrt(3)));
if (r_circle <= r_triangle)
{
    Console.WriteLine("Круг поместится в треугольник");
}
else if (r_triangle <= r_circle)
{
    Console.WriteLine("Треугольник поместится в круг");
}