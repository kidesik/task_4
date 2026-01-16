Console.WriteLine("Введите координаты левого нижнего угла 1 прямоугольника");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ширину 1 прямоугольника");
double w1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту 1 прямоугольника");
double h1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты левого нижнего угла 2 прямоугольника");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ширину 2 прямоугольника");
double w2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту 2 прямоугольника");
double h2 = Convert.ToDouble(Console.ReadLine());

double resX1 = Math.Min(x1, x2);
double resY1 = Math.Min(y1, y2);

double resX2 = Math.Max(x1 + w1, x2 + w2);
double resY2 = Math.Max(y1 + h1, y2 + h2);
