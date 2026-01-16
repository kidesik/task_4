
Console.WriteLine("введите натуральное число н");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10;
int b = n % 10;
double n_2 = Math.Pow(n, 2);
double sum_n_3 = Math.Pow(a,3) +  Math.Pow(b,3);
double sum_n_3_4 = 4*sum_n_3;
if (n_2 == sum_n_3_4)
{
    Console.WriteLine("условие выполняется");
}
else
{
    Console.WriteLine("условие не выполняется");
}