Console.Write("Введите натуральное число k (количество грибов): ");
int k =Convert.ToInt32(Console.ReadLine());
if (k < 1)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите натуральное число.");
    return;
}

string ending;
if (k % 100 >= 11 && k % 100 <= 14)
{
    ending = "грибов";
}
else
{
    int lastDigit = k % 10;
    if (lastDigit == 1)
    {
        ending = "гриб";
    }
    else if (lastDigit >= 2 && lastDigit <= 4)
    {
        ending = "гриба";
    }
    else
    {
        ending = "грибов";
    }
}