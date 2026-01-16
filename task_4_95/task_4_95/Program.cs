Console.Write("Введите целое число N : ");
int N = int.Parse(Console.ReadLine());
if (1 <= N && N <= 32) 
{
    int kth_digit;

    if (N <= 10)
    {
        // Сегмент 0-9, длина цифры 1
        // Номер числа = N - 1. Сама цифра и есть результат.
        kth_digit = N - 1;
    }
    else
    {
        // Сегмент 10-20, длина цифры 2
        int remaining_N = N - 10;
        // Номер числа в этом сегменте (начиная с 0)
        int num_index = (remaining_N - 1) / 2;
        // Само число
        int number = 10 + num_index;
        // Индекс цифры внутри числа (0 или 1)
        int digit_index = (remaining_N - 1) % 2;

        if (digit_index == 0)
        {
            kth_digit = number / 10; // Цифра десятков
        }
        else
        {
            kth_digit = number % 10; // Цифра единиц
        }
    }

    Console.WriteLine($"\nЦифра с номером {N}: {kth_digit}");
}
    