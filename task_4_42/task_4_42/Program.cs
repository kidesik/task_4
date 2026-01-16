Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
if ((x > 2) && (y > 2))
{
    Console.WriteLine("Для графика А точка находится в области I");
}
else
{
    Console.WriteLine("Для графика А точка находится вне области I");
}
if (x < -2 && y < -4){
    Console.WriteLine("Для графика Б точка находится в области I");
}
else
{
    Console.WriteLine("Для графика Б точка находится вне области I");
}