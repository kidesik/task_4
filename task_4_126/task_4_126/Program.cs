Console.Write("Введите целое ненулевое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое ненулевое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
string result = (b % a == 0) ? "a является делителем b" : ((a % b == 0) ? "b является делителем a" : "Ни одно из чисел не является делителем другого");
Console.WriteLine($"Результат: {result}");