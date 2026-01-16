using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num1)) { num1 = 1.0; }

        Console.WriteLine("Введите второе вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num2)) { num2 = -2.0; }

        Console.WriteLine("Введите третье вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num3)) { num3 = 3.0; }

        Console.WriteLine("Введите четвертое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num4)) { num4 = -4.0; }

       
        Solve(num1, num2, num3, num4);
    }

    static void Solve(double a, double b, double c, double d)
    {
        Console.WriteLine($"Подсчет отрицательных чисел из: {a}, {b}, {c}, {d} ---");

        int negativeCount = 0;

        if (a < 0)
        {
            negativeCount = negativeCount + 1; 
        }

        if (b < 0)
        {
            negativeCount = negativeCount + 1;
        }

        if (c < 0)
        {
            negativeCount = negativeCount + 1;
        }

        if (d < 0)
        {
            negativeCount = negativeCount + 1;
        }

        Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
    }
}