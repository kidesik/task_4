using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое вещественное число (a):");
        if (!double.TryParse(Console.ReadLine(), out double a)) { a = -5.0; }

        Console.WriteLine("Введите второе вещественное число (b):");
        if (!double.TryParse(Console.ReadLine(), out double b)) { b = 10.0; }


        Solve(a, b);
    }

    static void Solve(double a_in, double b_in)
    {
        Console.WriteLine($"Расчеты для чисел a = {a_in}, b = {b_in} ---");

       
        Func<double, double> getAbs = (num) =>
        {
            double abs_val = num;
            if (abs_val < 0)
            {
                abs_val = -abs_val;
            }
            return abs_val;
        };

        double abs_a = getAbs(a_in);
        double abs_b = getAbs(b_in);

        double halfSum = (abs_a + abs_b) / 2.0;
        Console.WriteLine($"а) Полусумма абсолютных величин: {halfSum}");

       
        double productRoot = Math.Sqrt(abs_a * abs_b);
        Console.WriteLine($"б) Квадратный корень из произведения абсолютных величин: {productRoot}");
    }
}
