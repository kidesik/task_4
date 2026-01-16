using System;

class Program
{

    static bool IsLeap(int year)
    {

        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

  
    static int GetDaysInMonth(int month, int year)
    {
        switch (month)
        {
            case 2:
                return IsLeap(year) ? 29 : 28;
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

        Console.WriteLine("Введите год (g):");
        int g = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер месяца (m, 1-12):");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число (n, день месяца):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Учитывать високосный год? (Да/Нет):");
        bool checkLeap = Console.ReadLine().ToLower() == "да";


        int effectiveYear = g;
        if (!checkLeap && IsLeap(g))
        {

            Console.WriteLine("Для случая 1 (год не является високосным) введите, пожалуйста, невисокосный год.");

        }


        int prevYear = g;
        int prevMonth = m;
        int prevDay = n - 1;

        if (prevDay < 1)
        {
            prevMonth--;
            if (prevMonth < 1)
            {
                prevMonth = 12;
                prevYear--;
            }

            prevDay = GetDaysInMonth(prevMonth, prevYear);
        }
        Console.WriteLine($"\nДата предыдущего дня: {prevDay}.{prevMonth}.{prevYear}");


        int nextYear = g;
        int nextMonth = m;
        int nextDay = n + 1;
        int daysInCurrentMonth = GetDaysInMonth(m, g);

        if (nextDay > daysInCurrentMonth)
        {
            nextDay = 1;
            nextMonth++;
            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear++;
            }
        }
        Console.WriteLine($"Дата следующего дня: {nextDay}.{nextMonth}.{nextYear}");
    }
}