
{
    Console.Write("Введите номер дня k (1-365): ");
    int k = Convert.ToInt32(Console.ReadLine());
    int dayOfWeekNumber = (k - 1) % 7 + 1;
    string result;

    switch (dayOfWeekNumber)
    {
        case 1: result = "понедельник"; break;
        case 2: result = "вторник"; break;
        case 3: result = "среда"; break;
        case 4: result = "четверг"; break;
        case 5: result = "пятница"; break;
        case 6: result = "суббота"; break;
        default: result = "воскресенье"; break;
    }
}
{
    Console.WriteLine($"День недели для {k}-го дня: {result}");
    Console.Write("Введите номер дня k (1-365): ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер дня недели 1 января d (1=пн, 7=вс): ");
    int d = Convert.ToInt32(Console.ReadLine());
    string result;

    int dayOfWeekNumber = (k - 1 + d - 1) % 7 + 1;

    switch (dayOfWeekNumber)
    {
        case 1: result = "понедельник"; break;
        case 2: result = "вторник"; break;
        case 3: result = "среда"; break;
        case 4: result = "четверг"; break;
        case 5: result = "пятница"; break;
        case 6: result = "суббота"; break;
        default: result = "воскресенье"; break;
    }

    Console.WriteLine($"День недели для {k}-го дня: {result}");
}
