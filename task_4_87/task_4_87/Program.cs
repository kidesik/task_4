Console.WriteLine("Введите год рождения первого человека:");
int year1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения первого человека:");
int month1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день рождения первого человека:");
int day1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год рождения второго человека:");
int year2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения второго человека:");
int month2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день рождения второго человека:");
int day2 = Convert.ToInt32(Console.ReadLine());
string resultMessage;
if (year1 < year2)
{
    resultMessage = "Первый человек старше второго.";
}
else if (year1 > year2)
{
    resultMessage = "Второй человек старше первого.";
}
else 
{
    if (month1 < month2)
    {
        resultMessage = "Первый человек старше второго.";
    }
    else if (month1 > month2)
    {
        resultMessage = "Второй человек старше первого.";
    }
    else 
    {
        if (day1 < day2)
        {
            resultMessage = "Первый человек старше второго.";
        }
        else if (day1 > day2)
        {
            resultMessage = "Второй человек старше первого.";
        }
        else
        {
            resultMessage = "Оба человека одного возраста (родились в один день).";
        }
    }
}

Console.WriteLine(resultMessage);