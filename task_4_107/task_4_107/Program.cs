using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num1)) { num1 = 1; }

        Console.WriteLine("Введите второе целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num2)) { num2 = 4; }

        Console.WriteLine("Введите третье целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num3)) { num3 = 7; }

   
        Solve(num1, num2, num3);
    }

    static void Solve(int a, int b, int c)
    {
        Console.WriteLine($" Проверка чисел на четность: {a}, {b}, {c} ");
        Console.WriteLine("Четные числа:");

        bool foundEven = false;

        if (a % 2 == 0)
        {
            Console.WriteLine(a);
            foundEven = true;
        }

        if (b % 2 == 0)
        {
            Console.WriteLine(b);
            foundEven = true;
        }

        if (c % 2 == 0)
        {
            Console.WriteLine(c);
            foundEven = true;
        }

        if (!foundEven)
        {
            Console.WriteLine("Четных чисел среди введенных нет.");
        }
    }
}