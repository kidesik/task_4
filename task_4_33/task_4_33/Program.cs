Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 100;
int b = n % 100 / 10;
int c = n % 100 % 10;
int s = a + b + c;
int p = a * b * c;
//а
if (10 <= s && s <= 99)
{
    Console.WriteLine("Сумма чисел двузначное");
}
else
{
    Console.WriteLine("Сумма чисел не двузначное");
}
//б
if (100 <= p && p <= 999)
{
    Console.WriteLine("Сумма чисел трехзначное");
}
else
{
    Console.WriteLine("Сумма чисел не трехзначное");
}
//в
if (p>n)
{
    Console.WriteLine("Произведение больше числа");
}
else if (p == n)
{
    Console.WriteLine("равны");
}
else
{
    Console.WriteLine("Произведение меньше числа");
}
//г
if (s% 5 == 0)
{
    Console.WriteLine("Сумма кратна пяти");
}
else
{
    Console.WriteLine("Сумма не кратна пяти");
}
//д
if (s % a == 0)
{
    Console.WriteLine("Сумма кратна первому числу числа н");
}
else
{
    Console.WriteLine("Сумма не кратна первому числу числа н");
}