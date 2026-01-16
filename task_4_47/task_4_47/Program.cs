Console.WriteLine("Введите значения a, b, c");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
//а) выполняется ли неравенство а < b < с;
if (a < b && b < c)
{
    Console.WriteLine("выполняется неравенство а < b < с");
}
else
{
    Console.WriteLine("не выполняется неравенство а < b < с");
}
//б) выполняется ли неравенство в > а > с.
if (b > a && a > c)
{
    Console.WriteLine("выполняется неравенство b > a > c.");
}
else
{
    Console.WriteLine("не выполняется неравенство b > a > c.");
}