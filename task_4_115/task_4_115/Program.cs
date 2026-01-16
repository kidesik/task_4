using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num1)) { num1 = 1; }

        Console.WriteLine("Введите второе целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num2)) { num2 = -2; }

        Console.WriteLine("Введите третье целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num3)) { num3 = 3; }

        Console.WriteLine("Введите четвертое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num4)) { num4 = -4; }

        Console.WriteLine("Введите пятое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num5)) { num5 = 5; }

        Console.WriteLine("Введите шестое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num6)) { num6 = -6; }

        Solve(num1, num2, num3, num4, num5, num6);
    }

    static void Solve(int a, int b, int c, int d, int e, int f)
    {
        Console.WriteLine($" Сумма положительных чисел из: {a}, {b}, {c}, {d}, {e}, {f} ");

        int sumPositive = 0;

       
        if (a > 0)
        {
            sumPositive = sumPositive + a;
        }

        if (b > 0)
        {
            sumPositive = sumPositive + b;
        }

        if (c > 0)
        {
            sumPositive = sumPositive + c;
        }

        if (d > 0)
        {
            sumPositive = sumPositive + d;
        }

        if (e > 0)
        {
            sumPositive = sumPositive + e;
        }

        if (f > 0)
        {
            sumPositive = sumPositive + f;
        }

        Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
    }
}