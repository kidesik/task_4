Console.WriteLine("Введите натуральное число a и n");
int a = Convert.ToInt32(Console.ReadLine());
int n  = Convert.ToInt32(Console.ReadLine());
if  (n % a == 0) {
    Console.WriteLine($"{a} является делителем {n}");
}
else
{
    Console.WriteLine("{a} не является делителем {n}");
}