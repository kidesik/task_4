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

        Console.WriteLine("Введите четвертое вещественное число (d):");
        if (!double.TryParse(Console.ReadLine(), out double d)) { d = 4.0; }


        SolveA_Max(a, b, c, d);

        SolveB_Min(a, b, c, d);
    }


    static void SolveA_Max(double a, double b, double c, double d)
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

        if (d > max_val)
        {
            max_val = d;
        }

        Console.WriteLine($"Наибольшее число: {max_val}");
    }

 
    static void SolveB_Min(double a, double b, double c, double d)
    {
        Console.WriteLine(" б) ");

        double min_val = a;

        if (b < min_val)
        {
            min_val = b;
        }

        if (c < min_val)
        {
            min_val = c;
        }

        if (d < min_val)
        {
            min_val = d;
        }

        Console.WriteLine($"Наименьшее число: {min_val}");
    }
}