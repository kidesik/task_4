Console.Write("Введите координату X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());
if  (x > 3 && y > 2)
{
    Console.WriteLine("Точка попадает в область I");
}
else
{
    Console.WriteLine("Точка не попадает в область I");
}