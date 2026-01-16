Console.Write("Введите шестизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100000 || number > 999999)
{
    Console.WriteLine("Ошибка! Число должно быть шестизначным.");
}
else
{
    int d1 = number / 100000;
    int d2 = (number / 10000) % 10;
    int d3 = (number / 1000) % 10;
    int d4 = (number / 100) % 10;
    int d5 = (number / 10) % 10;
    int d6 = number % 10;
    int firstSum = d1 + d2 + d3;
    int lastSum = d4 + d5 + d6;
    if (firstSum == lastSum)
    {
        Console.WriteLine($"Число {number} — счастливое! ({firstSum} = {lastSum})");
    }
    else
    {
        Console.WriteLine($"Число {number} — обычное. ({firstSum} != {lastSum})");
    }
}