Console.Write("Введите порядковый номер месяца (1-12): ");
int monthNumber = Convert.ToInt32(Console.ReadLine());
string season;

if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
{
    season = "Зима";
}
else if (monthNumber >= 3 && monthNumber <= 5)
{
    season = "Весна";
}
else if (monthNumber >= 6 && monthNumber <= 8)
{
    season = "Лето";
}
else if (monthNumber >= 9 && monthNumber <= 11)
{
    season = "Осень";
}
else
{
    season = "Ошибка: неверный номер месяца.";
}

Console.WriteLine($"Время года: {season}");
