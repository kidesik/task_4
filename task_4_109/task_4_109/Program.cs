using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num1)) { num1 = 1.0; }

        Console.WriteLine("Введите второе вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num2)) { num2 = 2.5; }

        Console.WriteLine("Введите третье вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num3)) { num3 = 4.0; }

   
        Solve(num1, num2, num3);
    }

    static void Solve(double a, double b, double c)
    {
        Console.WriteLine($" Проверка чисел на интервал [1.6, 3.8]: {a}, {b}, {c} ");
        Console.WriteLine("Числа, принадлежащие интервалу:");

        bool foundInRange = false;
        double lowerBound = 1.6;
        double upperBound = 3.8;


        if (a >= lowerBound && a <= upperBound)
        {
            Console.WriteLine(a);
            foundInRange = true;
        }

        if (b >= lowerBound && b <= upperBound)
        {
            Console.WriteLine(b);
            foundInRange = true;
        }

        if (c >= lowerBound && c <= upperBound)
        {
            Console.WriteLine(c);
            foundInRange = true;
        }

        if (!foundInRange)
        {
            Console.WriteLine("Введенные числа не принадлежат указанному интервалу.");
        }
    }
}