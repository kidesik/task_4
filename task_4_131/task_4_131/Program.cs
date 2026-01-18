Console.WriteLine("Введите три различных числа для первой тройки:");
double a1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double c1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите три различных числа для второй тройки:");
double a2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double c2 = Convert.ToDouble(Console.ReadLine());
double min1 = Math.Min(a1, Math.Min(b1, c1));
double max1 = Math.Max(a1, Math.Max(b1, c1));
double middle1 = (a1 + b1 + c1) - min1 - max1;
double min2 = Math.Min(a2, Math.Min(b2, c2));
double max2 = Math.Max(a2, Math.Max(b2, c2));
double middle2 = (a2 + b2 + c2) - min2 - max2;
double averageOfMiddles = (middle1 + middle2) / 2.0;
Console.WriteLine($"Среднее арифметическое средних чисел: {averageOfMiddles}");
  