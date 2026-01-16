Console.WriteLine("Введите двузначное число");
int n =Convert.ToInt32(Console.ReadLine());
int d = n / 10;
int e = n % 10;
//а) входят ли в него цифры 4 или 7;
if (d == 4|| e == 4)
{
    Console.WriteLine("в число входит 4");
}
else if (d == 7|| e == 7)
{
    Console.WriteLine("в число входит 7");
}
else if ((d== 7 && e == 4) ||(d == 4 && e == 7))
{
    Console.WriteLine("в число входит 4 и 7");
}
else
{
    Console.WriteLine("в число не входит 4 или 7");
}
//б) входят ли в него цифры 3, 6 или 9.
if (d == 3 || e == 3)
{
    Console.WriteLine("в число входит 3");
}
else if (d == 6 || e == 6)
{
    Console.WriteLine("в число входит 6");
}
else if (d == 9 || e == 9)
{
    Console.WriteLine("в число входит 9");
}
else if ((d == 3 && e == 6) || (d == 6 && e == 3))
{
    Console.WriteLine("в число входит 3 и 6");
}
else if ((d == 6 && e == 9) || (d == 9 && e == 6))
{
    Console.WriteLine("в число входит 9 и 6");
}
else if ((d == 9 && e == 3) || (d == 3 && e == 9))
{
    Console.WriteLine("в число входит 9 и 3");
}
else
{
    Console.WriteLine("в число не входит 3 или 6 или 9");
}