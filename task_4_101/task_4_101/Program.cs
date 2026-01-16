using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число (a):");
        if (!double.TryParse(Console.ReadLine(), out double a)) { a = 1.0; }

        Console.WriteLine("Введите второе вещественное число (b):");
        if (!double.TryParse(Console.ReadLine(), out double b)) { b = 2.0; }

        Console.WriteLine("Введите третье вещественное число (c):");
        if (!double.TryParse(Console.ReadLine(), out double c)) { c = 3.0; }

        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Числа должны быть различными. Пожалуйста, перезапустите программу с разными числами.");
            return;
        }


        SolveA_Max(a, b, c);


        SolveB_Min(a, b, c);
    }

    static void SolveA_Max(double a, double b, double c)
    {
        Console.WriteLine(" а) ");

        double max_val = a;


        if (b > max_val)
        {
            max_val = b;
        }


        if (c > max_val)
        {
            max_val = c;
        }

        Console.WriteLine($"Наибольшее число: {max_val}");
    }

    static void SolveB_Min(double a, double b, double c)
    {
        Console.WriteLine("б) ");

        double min_val = a;


        if (b < min_val)
        {
            min_val = b;
        }


        if (c < min_val)
        {
            min_val = c;
        }

        Console.WriteLine($"Наименьшее число: {min_val}");
    }
}