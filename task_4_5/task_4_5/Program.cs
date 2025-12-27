Console.WriteLine("Введите координаты точки");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (y > 3)
{
    Console.WriteLine("Точка находится в первой области");
}
else if (y < 3)
{
    Console.WriteLine("Точка находится во второй области");
}
else
{
    Console.WriteLine("Точка находится между областей");
}
