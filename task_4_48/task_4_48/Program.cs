Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0 || b % a == 0)
{
    Console.WriteLine("одно из чисел является делителем другого.");
}
else if (a % b == 0 && b % a == 0)
{
    Console.WriteLine("оба из чисела является делителем друг друга.");
}
else
{
    Console.WriteLine("ни одно из чисел является делителем другого.");
}