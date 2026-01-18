Console.Write("Введите первое число a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число c: ");
double c = Convert.ToDouble(Console.ReadLine());
double min = (a < b) ? ((a < c) ? a : c) : ((b < c) ? b : c);
double sumTwoLargest = (a + b + c) - min;
Console.WriteLine($"Сумма двух наибольших чисел: {sumTwoLargest}");