Console.WriteLine("Введите число a и b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b % a == 0)
{
    Console.WriteLine($"Число {a} является делителем числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является делителем числа {b}");
}
if  (a % b == 0)
{
    Console.WriteLine($"Число {b} является делителем числа {a}");
}
else
{
    Console.WriteLine($"Число {b} не является делителем числа {a}");
}