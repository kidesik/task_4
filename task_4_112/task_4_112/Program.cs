using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число (a):");
        if (!int.TryParse(Console.ReadLine(), out int num1)) { num1 = 1; } 

        Console.WriteLine("Введите второе целое число (b):");
        if (!int.TryParse(Console.ReadLine(), out int num2)) { num2 = -5; } 

        Console.WriteLine("Введите третье целое число (c):");
        if (!int.TryParse(Console.ReadLine(), out int num3)) { num3 = 10; } 

       
        Solve(num1, num2, num3);
    }

    static void Solve(int a, int b, int c)
    {
        Console.WriteLine($" Сумма положительных чисел из: {a}, {b}, {c} ");

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

        Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
    }
}