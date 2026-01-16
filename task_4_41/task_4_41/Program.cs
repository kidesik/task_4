// Дано натуральное число. Определить, является ли оно двузначным.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (10 <= n && n <= 99)
{
    Console.WriteLine("Число является двузначным");
}
else
{
    Console.WriteLine("Число не является двузначным");
}