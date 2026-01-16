Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());
int d = a / 10;
int e = a % 10;
int s = d + e;
if (s % 3 !=0) { Console.WriteLine("Сумма кратна 3"); }
else { Console.WriteLine("Сумма не кратна 3"); }
if (s % a == 0)
{
    Console.WriteLine("Сумма кратна числу а");
}
else if (s % a != 0)
{
    Console.WriteLine("Сумма не кратна числу а");
}