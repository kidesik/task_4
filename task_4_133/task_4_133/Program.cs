using System.Security.Cryptography;

Console.Write("Введите порядковый номер дня недели (1-7): ");
int n = Convert.ToInt32(Console.ReadLine());
    string dayName;
    if (n == 1)
    {
        dayName = "понедельник";
    }
    else if (n == 2)
    {
        dayName = "вторник";
    }
    else if (n == 3)
    {
        dayName = "среда";
    }
    else if (n == 4)
    {
        dayName = "четверг";
    }
    else if (n == 5)
    {
        dayName = "пятница";
    }
    else if (n == 6)
    {
        dayName = "суббота";
    }
    else if (n == 7)
    {
        dayName = "воскресенье";
    }
    else
    {
        dayName = "Ошибка: неверный номер дня.";
    }

    Console.WriteLine($"Название дня недели: {dayName}");
