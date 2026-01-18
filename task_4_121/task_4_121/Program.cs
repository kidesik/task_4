Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
string region = (x <= 0) ? "I" : ((x < 5) ? "II" : "III");
Console.WriteLine($"Точка попадает в область: {region}");