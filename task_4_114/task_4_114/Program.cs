using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num1)) { num1 = 3; } 

        Console.WriteLine("Введите второе целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num2)) { num2 = 4; } 

        Console.WriteLine("Введите третье целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num3)) { num3 = 6; } 

        Console.WriteLine("Введите четвертое целое число:");
        if (!int.TryParse(Console.ReadLine(), out int num4)) { num4 = 1; }  


        Solve(num1, num2, num3, num4);
    }

    static void Solve(int a, int b, int c, int d)
    {
        Console.WriteLine($" Сумма чисел, кратных 3, из: {a}, {b}, {c}, {d} ");

        int sumMultipleOfThree = 0;

    
        if (a % 3 == 0)
        {
            sumMultipleOfThree = sumMultipleOfThree + a;
        }

        if (b % 3 == 0)
        {
            sumMultipleOfThree = sumMultipleOfThree + b;
        }

        if (c % 3 == 0)
        {
            sumMultipleOfThree = sumMultipleOfThree + c;
        }

        if (d % 3 == 0)
        {
            sumMultipleOfThree = sumMultipleOfThree + d;
        }

        Console.WriteLine($"Сумма чисел, которые кратны трем: {sumMultipleOfThree}");
    }
}