using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num1)) { num1 = 10.0; }

        Console.WriteLine("Введите второе вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double num2)) { num2 = -5.0; }

      
        Solve(num1, num2);
    }

    static void Solve(double n1, double n2)
    {
        Console.WriteLine($" Обработка чисел: Первое = {n1}, Второе = {n2} ");

        double absN1 = Math.Abs(n1);
        double absN2 = Math.Abs(n2);

        Console.WriteLine($"Абсолютные величины: |{n1}| = {absN1}, |{n2}| = {absN2}");

        if (absN1 > absN2)
        {
            
            n1 = n1 / 2.0;
            Console.WriteLine("Условие выполнено: Первое число уменьшено в два раза.");
        }
        else
        {
            Console.WriteLine("Условие не выполнено: Первое число осталось без изменений.");
        }

        Console.WriteLine($"Конечное значение первого числа: {n1}");
        Console.WriteLine($"Конечное значение второго числа: {n2}");
    }
}