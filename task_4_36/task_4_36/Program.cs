Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 10) % 2 == 0)
{
    Console.WriteLine("число заканчивается четной цифрой.");
}
else
{
    Console.WriteLine("число заканчивается нечетной цифрой.");
}