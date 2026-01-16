// Дано четырехзначное число. Определить:
Console.WriteLine("Введите четырехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int t = n / 1000;
int s = n % 1000 / 100;
int d = n % 1000 % 100 / 10;
int e = n % 1000 % 100 % 10;
// а) входит ли в него цифра 4;
if ( t == 4 || s == 4|| d == 4 || e == 4)
{
    Console.WriteLine("Цифра 4 входит в число");
}
else
{
    Console.WriteLine("Цифра 4 не входит в число");
}
//б) входит ли в него цифра b.
Console.WriteLine("Введите цифру b");
int b  = Convert.ToInt32(Console.ReadLine());
if (t == b || s == b || d == b || e == b)
{
    Console.WriteLine($"Цифра {b} входит в число");
}
else
{
    Console.WriteLine($"Цифра {b} не входит в число");
}