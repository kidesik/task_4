Console.Write("Введите сторону стола a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону стола b (b < a) ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону карточки c ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону карточки d (d < c) ");
int d = Convert.ToInt32(Console.ReadLine());
int k_1 = (a / c) * (b / d);
int k_2 = (b / c) * (a / d);
if (k_1 > k_2)
{
    Console.WriteLine("Выгоднее размещать вдоль длинной стороны.");
}
else
{
    if (k_2 > k_1)
    {
        Console.WriteLine("Выгоднее размещать вдоль короткой стороны.");
    }
    else
    {
        Console.WriteLine("Количество одинаково в обоих случаях.");
    }
}