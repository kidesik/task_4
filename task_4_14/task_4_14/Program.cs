Console.WriteLine("Введите напряжение и сопротивление первой цепи, а затем второй цепи");
int U_1 = Convert.ToInt32(Console.ReadLine());
int R_1 = Convert.ToInt32(Console.ReadLine());
int U_2 = Convert.ToInt32(Console.ReadLine());
int R_2 = Convert.ToInt32(Console.ReadLine());
int I_1 = U_1 / R_1;
int I_2 = U_2 / R_2;
if (I_1 < I_2 && R_1 > R_2)
{
    Console.WriteLine($"меньший ток проходит через первую цепь и равен {I_1}");
}
else if (I_1 > I_2 &&  R_2 > R_1)
{
    Console.WriteLine($"меньший ток проходит через вторую цепь и равен {I_2}");
}
else
{
    Console.WriteLine("ток в обоих цепях равный");
}