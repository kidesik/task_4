// Проверить, принадлежит ли число, введенное с клавиа- туры, интервалу (-5, 3).
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= -5 && n <= 3)
{
    Console.WriteLine("число принадлежит интервалу (-5, 3).");
}
else
{
    Console.WriteLine("число не принадлежит интервалу (-5, 3).");
}