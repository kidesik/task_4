Console.Write("Введите порядковый номер карты (6-14): ");
int k = Convert.ToInt32(Console.ReadLine());
string cardRank;
if (k == 11)
{
    cardRank = "валет";
}
else if (k == 12)
{
    cardRank = "дама";
}
else if (k == 13)
{
    cardRank = "король";
}
else if (k == 14)
{
    cardRank = "туз";
}
else
{
    // Для карт 6, 7, 8, 9, 10
    cardRank = k.ToString();
}
Console.WriteLine($"Достоинство карты: {cardRank}");