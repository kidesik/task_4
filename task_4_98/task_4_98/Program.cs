Console.Write("Введите начальный номер квартиры (a): ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество квартир (n): ");
int n = int.Parse(Console.ReadLine());

bool isSumEven;

int remainderN = n % 4;

if (remainderN == 1 || remainderN == 3)
{
    isSumEven = (a % 2 == 0);
}
else
{

    isSumEven = (remainderN == 0);

    if (isSumEven)
    {
        Console.WriteLine("\nСумма номеров всех квартир является четным числом.");
    }
    else
    {
        Console.WriteLine("\nСумма номеров всех квартир является нечетным числом.");
    }
}