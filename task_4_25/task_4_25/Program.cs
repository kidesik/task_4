Console.WriteLine("введите натуральное число н");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine(n + 2);
}
else
{
    Console.WriteLine(n + 1);
}