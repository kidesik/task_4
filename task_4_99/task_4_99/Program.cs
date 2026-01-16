Console.Write("Введите первое вещественное число : ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("Некорректный ввод ");
    return;
}

Console.Write("Введите второе вещественное число : ");
if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("Некорректный ввод ");
    return;
}

if (num1 == num2)
{
    Console.WriteLine("Числа должны быть различными согласно условию задачи.");
    return;
}

double max_a = num1;
if (num2 > max_a)
{
    max_a = num2;
}

Console.WriteLine($"\nа) Наибольшее число (через два IF): {max_a}");


double max_b = num1;
if (num2 > max_b) max_b = num2;

Console.WriteLine($"\nб) Наибольшее число (через один IF): {max_b}");
