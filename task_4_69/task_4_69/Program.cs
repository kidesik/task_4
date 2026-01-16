
Console.WriteLine("Введите размеры 2 сторон стола");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размеры 3 граней кости домино");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int count_cd_1 = (a / c) * (b / d);
int count_cd_2 = (a / d) * (b / c);

int count_ce_1 = (a / c) * (b / e);
int count_ce_2 = (a / e) * (b / c);

int count_de_1 = (a / d) * (b / e);
int count_de_2 = (a / e) * (b / d);
int maxDominoes = Math.Max(Math.Max(Math.Max(count_cd_1, count_cd_2), Math.Max(count_ce_1, count_ce_2)), Math.Max(count_de_1, count_de_2));
Console.WriteLine($"На стол {a}x{b} можно положить максимум {maxDominoes} костей домино.");
if (maxDominoes == count_ce_1) { 
    Console.WriteLine("Лучший вариант: грань c x e (или e x c), уложенная вдоль длинной стороны стола."); 
}