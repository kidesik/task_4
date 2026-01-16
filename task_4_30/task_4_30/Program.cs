Console.WriteLine("Введите число н");
int n = Convert.ToInt32(Console.ReadLine());
int s = n / 100;
int d = n % 100 / 10;
int e  = n % 100 % 10;
int new_n = e*100 + d*10 + s;
if (new_n == n)
{
    Console.WriteLine("число н является палиндромом");
}
else
{
    Console.WriteLine("число н не является палиндромом");
}