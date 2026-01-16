using System.Data;

Console.Write("Введите стоимость в копейках (n от 1 до 9999): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}

int r = n / 100; 
int k = n % 100;
static string GetRublEnding(int r)
{
    if (r % 100 >= 11 && r % 100 <= 14) return "рублей";
    int lastDigit = r % 10;
    if (lastDigit == 1) return "рубль";
    if (lastDigit >= 2 && lastDigit <= 4) return "рубля";
    return "рублей";
}
static string GetKopeckEnding(int k)
{
    if (k % 100 >= 11 && k % 100 <= 14) return "копеек";
    int lastDigit = k % 10;
    if (lastDigit == 1) return "копейка";
    if (lastDigit >= 2 && lastDigit <= 4) return "копейки";
    return "копеек";
}
string rublText = GetRublEnding(r);
string kopeckText = GetKopeckEnding(k);
string result;
if (k == 0)
{
    result = $"{r} {rublText} ровно";
}
else
{
    result = $"{r} {rublText} {k} {kopeckText}";
}

Console.WriteLine($"\nСтоимость: {result}");
    