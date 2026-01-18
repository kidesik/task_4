Console.Write("Введите значение y: ");
double y = Convert.ToDouble(Console.ReadLine());
string region = (y >= 5.0) ? "I" : ((y > 2.5) ? "II" : "III");
Console.WriteLine($"Точка попадает в область: {region}");