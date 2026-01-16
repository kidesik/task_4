Console.WriteLine("Введите первое вещественное число (a):");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("Некорректный ввод. Используется значение по умолчанию: 5.0");
    a = 5.0;
}

Console.WriteLine("Введите второе вещественное число (b):");
if (!double.TryParse(Console.ReadLine(), out double b))
{
    Console.WriteLine("Некорректный ввод. Используется значение по умолчанию: 10.0");
    b = 10.0;
}

if (a == b)
{
    Console.WriteLine("Числа должны быть различными. Пожалуйста, перезапустите программу с разными числами.");
    return;
}


SolveA(a, b);

SolveB(a, b);
   


    static void SolveA(double a, double b)
{
    Console.WriteLine("а)");
    double temp;


    if (a > b)
    {
        temp = a;
        a = b;
        b = temp;
    }
    Console.WriteLine($"Наименьшее число (a): {a}");
    Console.WriteLine($"Наибольшее число (b): {b}");
}


static void SolveB(double x, double y)
{
    Console.WriteLine("\n--- б) Решение с одним неполным IF (определение наибольшего) ---");

    double max_val = x;


    if (y > max_val)
    {
        max_val = y;
    }

    Console.WriteLine($"Наибольшее число: {max_val}");

}