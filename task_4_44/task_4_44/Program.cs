Console.WriteLine("Введите значения x");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 5)
{
    Console.WriteLine("Точка попадает в область I");
}
else if (x< -1)
{
    Console.WriteLine("Точка попадает в область III");
}
else
{
    Console.WriteLine("Точка попадает в область II");
}