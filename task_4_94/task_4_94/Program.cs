Console.Write("Введите целое число k : ");
if (int.TryParse(Console.ReadLine(), out int k))
{
    if (1 <= k && k <= 180)
    {
        int num_index = (k - 1) / 2;
        int N = 10 + num_index;

        int digit_index = (k - 1) % 2;

        int kth_digit;
        if (digit_index == 0)
        {
            kth_digit = N / 10;
        }
        else
        {
            kth_digit = N % 10;
        }

        Console.WriteLine($"\nK-я цифра: {kth_digit}");
    }
    else
    {
        Console.WriteLine("Число k должно быть в диапазоне от 1 до 180.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод числа k.");
}
 