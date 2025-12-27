Console.WriteLine("Введите вещественные числа");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double max = a;
double min = b;
if (a < b){
    max = b;
    min = a;
    
}
Console.WriteLine($"max = {max} \nmin = {min}");