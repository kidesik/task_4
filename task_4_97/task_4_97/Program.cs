Console.Write("Введите целое число k : ");
int k = int.Parse(Console.ReadLine());
if (1 <= k && k <= 222)
{
    int kth_digit;

    if (k <= 9)
    {

        kth_digit = k;
    }
    else if (k <= 189)
    {

        int k_prime = k - 9;
        int num_index = (k_prime - 1) / 2;
        int number = 10 + num_index;
        int digit_index = (k_prime - 1) % 2;

        if (digit_index == 0)
            kth_digit = number / 10;
        else
            kth_digit = number % 10;
    }
    else
    {

        int k_prime = k - 189;
        int num_index = (k_prime - 1) / 3;
        int number = 100 + num_index;
        int digit_index = (k_prime - 1) % 3;

        if (digit_index == 0)
            kth_digit = number / 100;
        else if (digit_index == 1)
            kth_digit = (number / 10) % 10;
        else
            kth_digit = number % 10;
    }

    Console.WriteLine($"\nK-я цифра: {kth_digit}");
}
    