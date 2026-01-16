using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");

        if (!double.TryParse(Console.ReadLine(), out double num1)) { num1 = 4.0; }

        Console.WriteLine("Введите второе вещественное число (должно быть >= 0 для корня):");
        if (!double.TryParse(Console.ReadLine(), out double num2)) { num2 = 9.0; }


        Solve(num1, num2);
    }

    static void Solve(double a, double b)
    {
        Console.WriteLine($"Обработка чисел: Первое = {a}, Второе = {b} ");

        if (b < 0)
        {
            Console.WriteLine("Ошибка: Второе число должно быть неотрицательным для вычисления квадратного корня.");
            return;
        }

        double sqrtB = Math.Sqrt(b);
        Console.WriteLine($"Квадратный корень из второго числа (sqrt({b})): {sqrtB}");

        if (sqrtB < a)
        {
       
            b = b * 5.0;

        }
        else
        {
            Console.WriteLine("Второе число осталось без изменений.");
        }

        Console.WriteLine($"Конечное значение первого числа: {a}");
        Console.WriteLine($"Конечное значение второго числа: {b}");
    }
}