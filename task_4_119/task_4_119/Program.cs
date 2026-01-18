Console.Write("Введите значение y: ");
double y = Convert.ToDouble(Console.ReadLine());
double f_y = (y > 2) ? 2 : ((y > 0 && y <= 2) ? 0 : -3 * y);

Console.WriteLine($"Значение f(y): {f_y}");