Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
double y_a = (x <= -1) ? 0 : ((x < 0) ? x + 1 : 1);
double y_b = (x <= -1) ? 1 : ((x < 1) ? -x : -1);
double y_v = (x <= -1) ? 1 : ((x < 0) ? -x : ((x < 1) ? x : 1));
Console.WriteLine($"Для графика а:{y_a} \nДля графика б:{y_b} \nДля графика в:{y_v}");