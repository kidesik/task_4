
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0) {
    Console.WriteLine("Число четное"); }
else {
    Console.WriteLine("Число нечетное"); }


if (n % 10 == 7) { Console.WriteLine("Число оканчивается на 7"); }
else { Console.WriteLine("Число не оканчивается на 7"); }