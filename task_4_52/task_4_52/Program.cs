//Дано трехзначное число. Определить, входит ли в него цифра 6.
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int s = n / 100;
int d = n % 100 / 10;
int e = n % 100 % 10;
if (s == 6 || d == 6 || e == 6)
{
    Console.WriteLine("цифра 6 входит в число ");
}
else
{
    Console.WriteLine("цифра 6 не входит в число");
}