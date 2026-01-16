Console.Write("Введите номер дня");
int k = Convert.ToInt32(Console.ReadLine());
if (1<=k && k <= 365)
{
    int dayOfWeek = k % 7;
    if (dayOfWeek == 0 || dayOfWeek == 6)
    {
        Console.WriteLine($"День {k}-й — выходной день.");
    }
    else
    {
        Console.WriteLine($"День {k}-й — рабочий день.");
    }
}
else
{
    Console.WriteLine("ошибка ввода");
}