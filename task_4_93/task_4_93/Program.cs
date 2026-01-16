using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер дня в году k (1-365): ");
        int k = int.Parse(Console.ReadLine());

        // --- а) Если 1 января - понедельник ---
        Console.WriteLine("\n--- а) Если 1 января - понедельник ---");
        int dayOfWeekA = ((k - 1) % 7) + 1;
        PrintDayType(dayOfWeekA);

        // --- б) Если 1 января - d-й день недели ---
        Console.WriteLine("\n--- б) Если 1 января - d-й день недели ---");
        Console.Write("Введите d - день недели 1 января (1=Пн, 2=Вт, ..., 7=Вс): ");
        int d = int.Parse(Console.ReadLine());

        int dayOfWeekB = ((d + k - 2) % 7) + 1;
        PrintDayType(dayOfWeekB);
    }

    static void PrintDayType(int dayOfWeek)
    {
        string[] names = { "", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        Console.WriteLine($"День недели: {names[dayOfWeek]}");

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Это выходной день.");
        }
        else
        {
            Console.WriteLine("Это рабочий день.");
        }
    }
}