Console.Write("Введите порядковый номер масти (1-4): ");
int m = Convert.ToInt32(Console.ReadLine());
string suitName;

if (m == 1)
{
    suitName = "пики";
}
else if (m == 2)
{
    suitName = "трефы";
}
else if (m == 3)
{
    suitName = "бубны";
}
else if (m == 4)
{
    suitName = "червы";
}
else
{
    suitName = "Неизвестная масть"; // На случай, если проверка при вводе была некорректной
}

Console.WriteLine($"Название масти: {suitName}");