using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num1)) { num1 = 2.5; } 

        Console.WriteLine("Введите второе вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num2)) { num2 = -1.0; } 

        Console.WriteLine("Введите третье вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num3)) { num3 = 0.0; }  

        Solve(num1, num2, num3);
    }

    static void Solve(double a, double b, double c)
    {
        Console.WriteLine($" Обработка чисел: {a}, {b}, {c} ---");

   

 
        if (a >= 0)
        {
            a = a * a; 
            Console.WriteLine($"Первое число было неотрицательным и теперь равно: {a}");
        }
        else
        {
            Console.WriteLine($"Первое число ({a}) отрицательное и осталось без изменений.");
        }

  
        if (b >= 0)
        {
            b = b * b;
            Console.WriteLine($"Второе число было неотрицательным и теперь равно: {b}");
        }
        else
        {
            Console.WriteLine($"Второе число ({b}) отрицательное и осталось без изменений.");
        }


        if (c >= 0)
        {
            c = c * c;
            Console.WriteLine($"Третье число было неотрицательным и теперь равно: {c}");
        }
        else
        {
            Console.WriteLine($"Третье число ({c}) отрицательное и осталось без изменений.");
        }

        Console.WriteLine($"\nКонечные значения чисел: {a}, {b}, {c}");
    }
}