{
    Console.Write("Введите номер месяца m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n (не 1): ");
    int n = Convert.ToInt32(Console.ReadLine());

    int prevMonth = m;
    int prevDay = n - 1;

    if (prevDay == 0) 
    {
        if (m == 1) 
        {
            prevMonth = 12;
            prevDay = 31;
        }
        else
        {
            prevMonth = m - 1;
            if (prevMonth == 2) prevDay = 28; 
            else if (prevMonth == 4 || prevMonth == 6 || prevMonth == 9 || prevMonth == 11) prevDay = 30;
            else prevDay = 31;
        }
    }

    Console.WriteLine($"Дата предыдущего дня: {prevDay}.{prevMonth}");
}
{
    Console.Write("Введите номер месяца m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n (не 31, если декабрь): ");
    int n = Convert.ToInt32(Console.ReadLine());

    int nextMonth = m;
    int nextDay = n + 1;
    int daysInCurrentMonth;

    
    if (m == 2) daysInCurrentMonth = 28;
    else if (m == 4 || m == 6 || m == 9 || m == 11) daysInCurrentMonth = 30;
    else daysInCurrentMonth = 31;

    if (nextDay > daysInCurrentMonth) 
        nextDay = 1;
        if (m == 12) nextMonth = 1; 
        else nextMonth = m + 1;
    

    Console.WriteLine($"Дата следующего дня: {nextDay}.{nextMonth}");
}