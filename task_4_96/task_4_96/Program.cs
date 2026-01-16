Console.Write("Введите целое число k : ");
int k = int.Parse(Console.ReadLine());
if (1 <= k && k <= 252)
{
    int kth_digit;

    if (k <= 100)
    {
        // Сегмент двузначных чисел (от 50 до 99)
        int num_index = (k - 1) / 2;
        int number = 50 + num_index;
        int digit_index = (k - 1) % 2;

        if (digit_index == 0)
            kth_digit = number / 10; // Десятки
        else
            kth_digit = number % 10; // Единицы
    }
    else
    {
        // Сегмент трехзначных чисел (от 100 до 150)
        int k_prime = k - 100;
        int num_index = (k_prime - 1) / 3;
        int number = 100 + num_index;
        int digit_index = (k_prime - 1) % 3;

        if (digit_index == 0)
            kth_digit = number / 100; // Сотни
        else if (digit_index == 1)
            kth_digit = (number / 10) % 10; // Десятки
        else
            kth_digit = number % 10; // Единицы
    }

    Console.WriteLine($"\nK-я цифра: {kth_digit}");
}
   