Console.Write("Введите номер масти m (1-4): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер достоинства карты k (6-14): ");
int k = Convert.ToInt32(Console.ReadLine());
string suitName;
string rankName;
switch (m)
{
    case 1: suitName = "пик"; break;
    case 2: suitName = "треф"; break;
    case 3: suitName = "бубен"; break;
    case 4: suitName = "червей"; break;
    default: suitName = ""; break;
}
switch (k)
{
    case 6: rankName = "Шестерка"; break;
    case 7: rankName = "Семерка"; break;
    case 8: rankName = "Восьмерка"; break;
    case 9: rankName = "Девятка"; break;
    case 10: rankName = "Десятка"; break;
    case 11: rankName = "Валет"; break;
    case 12: rankName = "Дама"; break;
    case 13: rankName = "Король"; break;
    case 14: rankName = "Туз"; break;
    default: rankName = ""; break;
}
Console.WriteLine($"Полное название карты: {rankName} {suitName}");