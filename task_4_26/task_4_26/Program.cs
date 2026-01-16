Console.WriteLine("Введите двузначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10;
int b = n % 10;
if  (a == b)
{
    Console.WriteLine("Цифры одинаковы.");
}
else if (a<b)
{
    Console.WriteLine("Вторая цифра большечем первая");
}
else if (b < a)
{
    Console.WriteLine("Первая цифра большечем вторая");
}