using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num1)) { num1 = 1; }

        Console.WriteLine("Введите второе целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num2)) { num2 = 2; }

        Console.WriteLine("Введите третье целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num3)) { num3 = 3; }

        Console.WriteLine("Введите четвертое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num4)) { num4 = 4; }

        Solve(num1, num2, num3, num4);
    }

    static void Solve(int a, int b, int c, int d)
    {
        Console.WriteLine($"Подсчет четных чисел из: {a}, {b}, {c}, {d} ---");

        int evenCount = 0;

        if (a % 2 == 0)
        {
            evenCount++;
        }

        if (b % 2 == 0)
        {
            evenCount++;
        }

        if (c % 2 == 0)
        {
            evenCount++;
        }

        if (d % 2 == 0)
        {
            evenCount++;
        }

        Console.WriteLine($"Количество четных чисел: {evenCount}");
    }
}