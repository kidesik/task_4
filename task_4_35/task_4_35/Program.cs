Console.WriteLine("Введите четырехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 1000;
int b = n % 1000 / 100;
int c = n % 1000 % 100 / 10;
int d = n % 1000 % 100 % 10;
if (a + b == c + d)
{
    Console.WriteLine("Сумма первых двух цифр равна сумме последних");
}
else
{
    Console.WriteLine("Сумма первых двух цифр не равна сумме последних");
}
if ((a + b + c + d) % 3 == 0)
{
    Console.WriteLine("Сумма цифр кратна трем");
}
else
{
    Console.WriteLine("Сумма цифр не кратна трем");
}
if ((a * b * c * d) % 4 == 0)
{
    Console.WriteLine("Произведение цифр кратна четырем");

}
else
{
    Console.WriteLine("Произведение цифр не кратна четырем ");
}
if ((a * b * c * d) % a == 0)
{
    Console.WriteLine($"Произведение цифр кратно числу {a}.");
}
else
{
    Console.WriteLine($"Произведение цифр не кратно числу {a}.");
}