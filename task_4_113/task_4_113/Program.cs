using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num1)) { num1 = 1.0; }

        Console.WriteLine("Введите второе вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num2)) { num2 = 6.0; } // > 5

        Console.WriteLine("Введите третье вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num3)) { num3 = 5.0; }  // Не > 5

        Console.WriteLine("Введите четвертое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num4)) { num4 = 10.5; } // > 5

      
        Solve(num1, num2, num3, num4);
    }

    static void Solve(double a, double b, double c, double d)
    {
        Console.WriteLine($" Сумма чисел больше 5 из: {a}, {b}, {c}, {d} ---");

        double sumGreaterFive = 0.0;


        if (a > 5.0)
        {
            sumGreaterFive = sumGreaterFive + a;
        }

        if (b > 5.0)
        {
            sumGreaterFive = sumGreaterFive + b;
        }

        if (c > 5.0)
        {
            sumGreaterFive = sumGreaterFive + c;
        }

        if (d > 5.0)
        {
            sumGreaterFive = sumGreaterFive + d;
        }

        Console.WriteLine($"Сумма чисел, которые больше пяти: {sumGreaterFive}");
    }
}