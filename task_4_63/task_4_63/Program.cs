Console.WriteLine("Введите размеры конверта(a,b) и размеры открытки(c,d)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
if ((c + 2 <= a && d + 2 <= b) || (c + 2 <= b && d + 2 <= a)){
    Console.WriteLine("Открытка войдет в конверт.");
}
else {
    Console.WriteLine("Открытка не войдет в конверт.");
}
