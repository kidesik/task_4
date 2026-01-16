Console.WriteLine("Введите минуты");
int t = Convert.ToInt32(Console.ReadLine());
double cycle_Time = t % 5;
if (cycle_Time >= 0 && cycle_Time < 3)
{
    Console.WriteLine("Зеленый");
}
else
{
    Console.WriteLine("Красный");
}