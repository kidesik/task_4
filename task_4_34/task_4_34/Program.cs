Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100;
int b = n % 100 / 10;
int c = n % 100 % 10;
if  (a == b &&  c == a && c == b)
{
    Console.WriteLine("все цифры одинаковые");
}
else
{
    Console.WriteLine("все цифры не одинаковые");
}
if (a == b || a == c || b == c) { Console.WriteLine("есть одинаковые цифры"); }
else
{
    Console.WriteLine("одинаковых цифр нет");
}