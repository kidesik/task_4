using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вещественное число:");
        if (!double.TryParse(Console.ReadLine(), out double number))
        {
            Console.WriteLine("Некорректный ввод. Используется значение по умолчанию: -5.0");
            number = -5.0;
        }

        CalculateAbsoluteValue(number);
    }

    static void CalculateAbsoluteValue(double n)
    {

        double abs_val = n;


        if (abs_val < 0)
        {
            abs_val = -abs_val;
        }

        Console.WriteLine($"Абсолютная величина числа: {abs_val}");
    }
}