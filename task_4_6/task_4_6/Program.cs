{
    Console.WriteLine("a) Введите координату x");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x < 2)
    {
        int y = x;
        Console.WriteLine($"y = {y}");
    }
    else if (x >= 2)
    {
        int y = 2;
        Console.WriteLine($"y = {y}");
    }
}
{
    Console.WriteLine("b) Введите координату x");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x < 3 && x > 0)
    {
        int y = -x;
        Console.WriteLine($"y = {y}");
    }
    else if (x >= 3)
    {
        int y = -3;
        Console.WriteLine($"y = {y}");
    }
    else if (x == 0)
    {
        int y = 0;
        Console.WriteLine($"y = {y}");
    }
}
