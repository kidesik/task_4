Console.Write("Введите количество очков (0, 1 или 3): ");
double points = Convert.ToDouble(Console.ReadLine());
string result = (points == 3) ? "выигрыш" : ((points == 0) ? "проигрыш" : "ничья");
Console.WriteLine($"Результат игры: {result}");