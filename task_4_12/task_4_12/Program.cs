Console.WriteLine("Hello, World!");
//Площадь круга: \(S_{ круга}=\pi \cdot r^{2}\) (где \(r\) – радиус).Площадь квадрата: \(S_{ квадрата}= a ^{ 2}\) (где \(a\) – сторона)
int r = Convert.ToInt32(Console.ReadLine());
int a  = Convert.ToInt32(Console.ReadLine());
double s_circle = r * Math.PI;
double s_square = Math.Pow(a, 2);
if (s_square < s_circle)
{
    Console.WriteLine($"Площадь круга {s_circle} больше, чем площадь квадрата");
}
else if (s_square > s_circle)
{
    Console.WriteLine($"Площадь квадрата {s_square} больше, чем площадь круга");
}
else
{
    Console.WriteLine("Площади равны");
}
