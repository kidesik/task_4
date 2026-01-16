Console.WriteLine("Введите год рождения:");
int yearOfBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца рождения (1-12):");
int monthOfBirth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите текущий год:");
int currentYear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите текущий номер месяца (1-12):");
int currentMonth = Convert.ToInt32(Console.ReadLine());
int fullYears = currentYear - yearOfBirth;
int fullMonths = currentMonth - monthOfBirth;
if (fullMonths < 0)
{
    fullYears--; 
    fullMonths += 12; 
}

Console.WriteLine($"Возраст человека: {fullYears} полных лет и {fullMonths} полных месяцев.");