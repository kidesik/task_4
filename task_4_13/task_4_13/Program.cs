Console.WriteLine("Введите массу и объем первого тела и затем введите массу и объем второго тела");
int m_1 = Convert.ToInt32(Console.ReadLine());
int v_1  = Convert.ToInt32(Console.ReadLine());
int m_2  = Convert.ToInt32(Console.ReadLine());
int v_2  = Convert.ToInt32(Console.ReadLine());
int p_1 = m_1 / v_1;
int p_2 = m_2 / v_2;
if  (p_1 < p_2)
{
    Console.WriteLine($"Плотность второго тела больше плотности первого и равно {p_2}");
}
else if (p_2 < p_1)
{
    Console.WriteLine($"Плотность первого тела больше плотности второго и равно {p_1}");
}
else
{
    Console.WriteLine("обе плотности равны");
}