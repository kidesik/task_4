
Console.WriteLine("Введите цифры первого двузначного числа (Уменьшаемое):");
Console.Write("Цифра десятков (a2): ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Цифра единиц (a1): ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nВведите цифры второго двузначного числа (Вычитаемое):");
Console.Write("Цифра десятков (b2): ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Цифра единиц (b1): ");
int b1 = Convert.ToInt32(Console.ReadLine());
int d1 = ((10 * a2 + a1) - (10 * b2 + b1)) / 10;
int d2 = ((10 * a2 + a1) - (10 * b2 + b1)) % 10;
Console.WriteLine($"Цифры числа, равного разности (результат):");
Console.WriteLine($"Цифра десятков (d1): **{d1}**");
Console.WriteLine($"Цифра единиц (d2): **{d2}**");