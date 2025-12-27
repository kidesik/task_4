Console.WriteLine("Введите скорость в км/ч и в м/с");
int km_h =Convert.ToInt32(Console.ReadLine());
int m_s =Convert.ToInt32(Console.ReadLine());
if ((km_h * 1000/3600) > m_s)
{
    Console.WriteLine("Скорость в к/ч больше");
}
else if ((km_h * 1000 / 3600) < m_s)
{
    Console.WriteLine("Скорость в м/с больше");
}
else
{
    Console.WriteLine("Скорости равны"); 
}
