Console.Write("Введите количество прошедших месяцев n: ");
int n = Convert.ToInt32(Console.ReadLine());

int monthNumber = n + 1; 
string monthName;

switch (monthNumber)
{
    case 1: monthName = "январь"; break;
    case 2: monthName = "февраль"; break;
    case 3: monthName = "март"; break;
    case 4: monthName = "апрель"; break;
    case 5: monthName = "май"; break;
    case 6: monthName = "июнь"; break;
    case 7: monthName = "июль"; break;
    case 8: monthName = "август"; break;
    case 9: monthName = "сентябрь"; break;
    case 10: monthName = "октябрь"; break;
    case 11: monthName = "ноябрь"; break;
    case 12: monthName = "декабрь"; break;
    default: monthName = "Ошибка: неверный номер месяца."; break;
}

Console.WriteLine($"Название месяца: {monthName}");