Console.WriteLine("Введите размеры двух сторон форточки");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if ((a >= 4) && (b >= 4))
{
    Console.WriteLine("Вася сможет высунуть голову");
}
else
{
    Console.WriteLine("Вася не сможет высунуть голову");
}