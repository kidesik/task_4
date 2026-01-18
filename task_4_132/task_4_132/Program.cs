Console.Write("Введите координату x (x != 0): ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y (y != 0): ");
double y = Convert.ToDouble(Console.ReadLine());
int quadrant = (x > 0) ? ((y > 0) ? 1 : 4) : ((y > 0) ? 2 : 3);
Console.WriteLine($"Точка находится в {quadrant} четверти.");