Console.Write("Введите номер года n: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
{
    Console.WriteLine("високосный год.");
}
else
{
    Console.WriteLine("невисокосный год.");
}