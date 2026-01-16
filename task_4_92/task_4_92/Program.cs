
Console.WriteLine("Введите время в минутах, прошедшее с начала часа (вещественное число):");

double r = Convert.ToDouble(Console.ReadLine());


double timeInCycle = r % 6.0;

string color;


if (timeInCycle >= 0 && timeInCycle < 3)
{
    color = "Зеленый";
}
else if (timeInCycle >= 3 && timeInCycle < 4)
{
    color = "Желтый";
}
else 
{
    color = "Красный";
}

Console.WriteLine($"В момент времени {r} минут горит сигнал: {color}");