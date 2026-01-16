Console.WriteLine("Введите неотрицательное целое числа а, положительное число b,а так же числа c и d");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int r = a % b;
if  (r == c || r == d)
{
    Console.WriteLine("условие выполняется");
}
else
{
    Console.WriteLine("условие не выполняется");
}