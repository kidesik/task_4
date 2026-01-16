Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите цифру n для поиска: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = number / 100;
int d = number % 100 / 10;
int e = number % 100 % 10;
//а) входит ли в него цифра 6;
if (s == 6 || d == 6|| e== 6)
{
    Console.WriteLine("Цифра 6 входит в число.");
}
else
{
    Console.WriteLine("Цифра 6 не входит в число.");
}
//б) входит ли в него цифра n.
if (s == n || d == n || e == n)
{
    Console.WriteLine($"Цифра {n} входит в число.");
}
else
{
    Console.WriteLine($"Цифра {n} не входит в число.");
}