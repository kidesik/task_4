Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
double y = (x < -1) ? -1 : (x == -1 ? 1 : x);

Console.WriteLine($"Значение y(x): {y}");