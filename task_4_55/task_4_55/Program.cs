Console.WriteLine("Введите четырехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int t = n / 1000;
int s = n %1000 / 100;
int d = n % 1000 % 100 / 10;
int e = n % 1000 % 100 % 10;
//а) входят ли в него цифры 4 или 7;
if (t == 4||s == 4 || d == 4 || e == 4)
{
    Console.WriteLine("в число входит 4");
}
else if (t == 7 || s == 7 || d == 7 || e == 7)
{
    Console.WriteLine("в число входит 7");
}
else if ((t == 4 || s == 4 || d == 4 || e == 4)&& (t == 7 || s == 7 || d == 7 || e == 7))
{
    Console.WriteLine("в число входит 4 и 7");
}
else
{
    Console.WriteLine("в число не входит 4 или 7");
}
//б) входят ли в него цифры 3, 6 или 9.
if (t == 3 || s == 3 || d == 3 || e == 3)
{
    Console.WriteLine("в число входит 3");
}
else if (t == 6 || s == 6 || d == 6 || e == 6)
{
    Console.WriteLine("в число входит 6");
}
else if (t == 9 || s == 9 || d == 9 || e == 9)
{
    Console.WriteLine("в число входит 9");
}
else if ((t == 3 || s == 3 || d == 3 || e == 3)&& (t == 6 || s == 6 || d == 6 || e == 6))
{
    Console.WriteLine("в число входит 3 и 6");
}
else if ((t == 6 || s == 6 || d == 6 || e == 6)&& (t == 9 || s == 9 || d == 9 || e == 9))
{
    Console.WriteLine("в число входит 9 и 6");
}
else if ((t == 9 || s == 9 || d == 9 || e == 9)&& (t == 6 || s == 6 || d == 6 || e == 6))
{
    Console.WriteLine("в число входит 9 и 3");
}
else if ((t == 9 || s == 9 || d == 9 || e == 9) && (t == 6 || s == 6 || d == 6 || e == 6) && (t == 3 || s == 3 || d == 3 || e == 3))
{
    Console.WriteLine("в число входит 9 и 3 и 6");
}
else
{
    Console.WriteLine("в число не входит 3 или 6 или 9");
}