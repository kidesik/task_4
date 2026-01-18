Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
double f_x = (x <= 0) ? 0 : ((x < 1) ? x : x * x);
Console.WriteLine($"Значение f(x): {f_x}");