using System;

class Program
{
    static int GetDaysInMonth(int month)
    {
        switch (month)
        {
            case 2:
                return 28;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            default:
                return 31;
        }
    }
    static void Main()
    {

        Console.WriteLine("Введите номер месяца (m, 1-12):");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число (n, день месяца):");
        int n = Convert.ToInt32(Console.ReadLine());

        int prevMonth = m;
        int prevDay = n - 1;

        if (prevDay < 1)
        {
            prevMonth--;
            if (prevMonth < 1)
            {
                prevMonth = 12;
            }
            prevDay = GetDaysInMonth(prevMonth);
        }
        Console.WriteLine($"\nДата предыдущего дня: {prevDay}.{prevMonth}");

        int nextMonth = m;
        int nextDay = n + 1;
        int daysInCurrentMonth = GetDaysInMonth(m);

        if (nextDay > daysInCurrentMonth)
        {
            nextDay = 1;
            nextMonth++;
            if (nextMonth > 12)
            {
                nextMonth = 1;
            }
        }
        Console.WriteLine($"Дата следующего дня: {nextDay}.{nextMonth}");
    }
}