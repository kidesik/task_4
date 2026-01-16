Console.Write("Введите возраст человека (целое число n от 1 до 99): ");
int n = Convert.ToInt32(Console.ReadLine());
if ( n < 1 || n > 99)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 99.");
    return;
}
string ending;
if (n % 100 >= 11 && n % 100 <= 14)
{
    ending = "лет";
}
else
{
    int lastDigit = n % 10;
    if (lastDigit == 1)
    {
        ending = "год";
    }
    else if (lastDigit >= 2 && lastDigit <= 4)
    {
        ending = "года";
    }
    else
    {
        ending = "лет";
    }
}

Console.WriteLine($"\nФраза: \"мне {n} {ending}\"");