
Console.Write("Введите четырехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int t = number / 1000;         
int s = (number / 100) % 10;   
int d = (number / 10) % 10;    
int e = number % 10;
if (t == e && s == d)
{
    Console.WriteLine("Число является симметричным.");
}
else
{
    Console.WriteLine("Число не является симметричным.");
}