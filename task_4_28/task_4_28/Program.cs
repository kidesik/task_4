Console.WriteLine("Введите натуральное число н");
int n = Convert.ToInt32(Console.ReadLine());
int d = n / 10;
int  b = n % 10;
int s = d + b;
Console.WriteLine("Введите натуральное число a");
int a = Convert.ToInt32(Console.ReadLine());
if (s >= 10)
{
    Console.WriteLine("Cумма цифр является двузначным числом");
}
else if (s < 10)
{
    Console.WriteLine("Cумма цифр не является двузначным числом");
}
if (s > a) { Console.WriteLine("Число a больше суммы цифр числа н");
}
else if (s<= a) {
    Console.WriteLine("");
}