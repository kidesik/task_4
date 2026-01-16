Console.WriteLine("Введите год рождения первого человека");
int yearOfBirth_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца рождения первого человека");
int monthOfBirth_1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите день рождения первого человека");
int dayOfBirth_1 = Convert.ToInt32(Console.ReadLine());

int currentYear = 2026;
int currentMonth = 1; 
int currentDay = 3;
int age = currentYear - yearOfBirth_1;

if (currentMonth < monthOfBirth_1 || (currentMonth == monthOfBirth_1 && currentDay < dayOfBirth_1))
{
    age--;
}

Console.WriteLine($"Возраст человека: {age} полных лет.");
 