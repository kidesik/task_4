Console.Write("Введите порядковый номер месяца (1-12): ");
int monthNumber = Convert.ToInt32(Console.ReadLine());
string monthName;

if (monthNumber == 1)
{
    monthName = "январь";
}
else if (monthNumber == 2)
{
    monthName = "февраль";
}
else if (monthNumber == 3)
{
    monthName = "март";
}
else if (monthNumber == 4)
{
    monthName = "апрель";
}
else if (monthNumber == 5)
{
    monthName = "май";
}
else if (monthNumber == 6)
{
    monthName = "июнь";
}
else if (monthNumber == 7)
{
    monthName = "июль";
}
else if (monthNumber == 8)
{
    monthName = "август";
}
else if (monthNumber == 9)
{
    monthName = "сентябрь";
}
else if (monthNumber == 10)
{
    monthName = "октябрь";
}
else if (monthNumber == 11)
{
    monthName = "ноябрь";
}
else if (monthNumber == 12)
{
    monthName = "декабрь";
}
else
{
    monthName = "неверный номер месяца.";
}

Console.WriteLine($"Название месяца: {monthName}");