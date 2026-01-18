Console.Write("Введите первое число a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число c: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
double productTwoSmallest = (a * b * c) / max;
Console.WriteLine($"Произведение двух наименьших чисел: {productTwoSmallest}");