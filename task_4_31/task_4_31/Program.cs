Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100;
int b = n % 100 / 10;
int c = n % 100 % 10;
//a
if (a > c)
{
    Console.WriteLine("Первая больше последней");
}
else if (c > a)
{
    Console.WriteLine("Последняя больше первой");
}
else
{
    Console.WriteLine("Первая и последняя равны");
}
//б
if (a > b)
{
    Console.WriteLine("Первая больше второй");
}
else if (b > a){ Console.WriteLine("Вторая больше первой"); }
else {Console.WriteLine("Первая и вторая равны");}
//в
if (b > c)
{
    Console.WriteLine("Вторая больше последней");
}
else if (c > b)
{
    Console.WriteLine("Последняя больше второй");
}
else { 
    Console.WriteLine("Вторая и последняя равны"); 
}