Console.Write("Введите значение a: ");
double a = Convert.ToDouble(Console.ReadLine());
double z = (a > 0) ? 1 : (a == 0 ? 0 : -1);

Console.WriteLine($"Значение z(x): {z}");