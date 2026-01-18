Console.Write("Введите порядковый номер месяца (1-12): ");
int monthNumber = Convert.ToInt32(Console.ReadLine());
int days;
if (monthNumber == 2)
{
    days = 28; 
}
else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
{
    days = 30; 
}
else
{
    days = 31; 
}
Console.WriteLine($"В {monthNumber}-м месяце {days} дней.");