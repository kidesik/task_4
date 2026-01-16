Console.WriteLine("Введите значения площади круга и квадрата");
double S_circle = Convert.ToDouble(Console.ReadLine());
double S_square  = Convert.ToDouble(Console.ReadLine());
double r = Math.Sqrt(S_circle / Math.PI);
double a = Math.Sqrt(S_square);
if ((2*r) <= a )
{
    Console.WriteLine("Круг поместится в квадрате");
}
else if ((a*Math.Sqrt(2)) <= (2*r))
{
    Console.WriteLine("Квадрат поместится в круге");
}