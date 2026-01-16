using System;
using static System.Math;

Console.WriteLine("Введите начальную скорость");
double v0 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угол броска");
double alpha = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите расстояние");
double R = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту H");
double H = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту P");
double P = Convert.ToDouble(Console.ReadLine());
double g = 9.8;
double alphaRad = alpha * PI / 180;
if (v0 == 0 || Cos(alphaRad) == 0)
{
    Console.WriteLine("Снаряд не полетит к цели (некорректные V0 или Alpha).");
}
else
{
    double t = R / (v0 * Cos(alphaRad));
    double Y = v0 * t * Sin(alphaRad) - (g * t * t) / 2;
    if (Y >= H && Y <= H + P)
    {
        Console.WriteLine($"\nСнаряд поразит цель! Высота снаряда в точке R: {Y:F2} м.");
    }
    else if (Y < H && Y > 0)
    {
        Console.WriteLine($"\nСнаряд пролетит ниже цели. Высота снаряда: {Y:F2} м.");
    }
    else if (Y > H + P)
    {
        Console.WriteLine($"\nСнаряд пролетит выше цели. Высота снаряда: {Y:F2} м.");
    }
    else 
    {
        Console.WriteLine($"\nСнаряд упадет на землю, не долетев до цели (Y = {Y:F2} м).");
    }
}