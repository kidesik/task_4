Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100;
int b = n % 100 / 10;
int c = n % 100 % 10;
double s_1 = Math.Pow(n, 2);
double s_2 = Math.Pow(a,3) + Math.Pow(b, 3) + Math.Pow(c, 3);
if (s_1 == s_2)
{
    Console.WriteLine("квадрат этого числа равен сумме кубов его цифр и условие выполняется.");
}
else
{
    Console.WriteLine("квадрат этого числа не равен сумме кубов его цифр и условие не выполняется.");
}