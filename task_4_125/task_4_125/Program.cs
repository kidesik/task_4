Console.Write("Введите вес боксера в кг: ");
double weight = Convert.ToDouble(Console.ReadLine());
string category = (weight < 60) ? "Легкий вес" : ((weight < 64) ? "Первый полусредний вес" : "Полусредний вес");
Console.WriteLine($"Боксер будет выступать в категории: {category}");