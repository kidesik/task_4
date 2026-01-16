Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру, которую нужно найти в числе");
int a  = Convert.ToInt32(Console.ReadLine());
int d = n / 10;
int e = n % 10;
if (d == 3 || e == 3)
{
    Console.WriteLine("Число 3 входит");
}
else
{
    Console.WriteLine("Число 3 не входит");
}
if (d == a || e == a)
{
    Console.WriteLine($"Число {a} входит");
}
else
{
    Console.WriteLine($"Число {a} не входит");
}