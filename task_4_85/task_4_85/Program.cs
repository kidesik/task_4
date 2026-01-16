static string GetYearEnding(int n)
{
    if (n % 100 >= 11 && n % 100 <= 14) return "лет";
    int lastDigit = n % 10;
    if (lastDigit == 1) return "год";
    if (lastDigit >= 2 && lastDigit <= 4) return "года";
    return "лет";
}
static string GetMonthEnding(int n)
{
    if (n % 100 >= 11 && n % 100 <= 14) return "месяцев";
    int lastDigit = n % 10;
    if (lastDigit == 1) return "месяц";
    if (lastDigit >= 2 && lastDigit <= 4) return "месяца";
    return "месяцев";
}
Console.Write("Введите возраст в месяцах (n от 1 до 1188): ");
int n = Convert.ToInt32(Console.ReadLine());
if ( n < 1 || n > 1188)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}
int years = n / 12;
int months = n % 12;
string yearText = GetYearEnding(years);
string monthText = GetMonthEnding(months);
string result;
if (months == 0)
{
    result = $"{years} {yearText} ровно";
}
else
{
    result = $"{years} {yearText} {months} {monthText}";
}

Console.WriteLine($"\nВозраст: {result}");