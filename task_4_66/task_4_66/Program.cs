double[] a = new double[3];

Console.WriteLine("Введите 3 размера чемодана:");
for (int i = 0; i < 3; i++)
{
    Console.Write($"Размер {i + 1}: ");
        a[i] = Convert.ToDouble(Console.ReadLine());
}
double[] b = new double[3];
Console.WriteLine("Введите 3 размера коробки:");
for (int i = 0; i < 3; i++)
{
    Console.Write($"Размер {i + 1}: ");
    b[i] = Convert.ToDouble(Console.ReadLine());
}
Array.Sort(a);
Array.Sort(b);
if (b[0] <= a[0] && b[1] <= a[1] && b[2] <= a[2])
    Console.WriteLine("Можно сэкономить (коробка влезет в чемодан).");
else
    Console.WriteLine("Сэкономить не удастся.");