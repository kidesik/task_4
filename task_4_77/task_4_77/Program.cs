using System;

class Program
{

      static bool CanMoveRook(int startX, int startY, int endX, int endY)
    {
        return startX == endX || startY == endY;
    }

      static bool CanMoveBishop(int startX, int startY, int endX, int endY)
    {
        return Math.Abs(startX - endX) == Math.Abs(startY - endY);
    }

    static bool CanMoveQueen(int startX, int startY, int endX, int endY)
    {
        return CanMoveRook(startX, startY, endX, endY) || CanMoveBishop(startX, startY, endX, endY);
    }

    static bool CanMoveKnight(int startX, int startY, int endX, int endY)
    {
        return (Math.Abs(startX - endX) == 1 && Math.Abs(startY - endY) == 2) ||
               (Math.Abs(startX - endX) == 2 && Math.Abs(startY - endY) == 1);
    }

    static bool CanMoveKing(int startX, int startY, int endX, int endY)
    {
        return Math.Abs(startX - endX) <= 1 && Math.Abs(startY - endY) <= 1 && !(startX == endX && startY == endY);
    }

    static void Main()
    {
        Console.WriteLine("Введите координаты белой фигуры (a, b) и черной фигуры (c, d), и целевого поля (e, f):");
        Console.Write("Белая фигура, вертикаль (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Белая фигура, горизонталь (b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Черная фигура, вертикаль (c): ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Черная фигура, горизонталь (d): ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Целевое поле, вертикаль (e): ");
        int e = Convert.ToInt32(Console.ReadLine());
        Console.Write("Целевое поле, горизонталь (f): ");
        int f = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- Результаты проверок (True = ход возможен) ---");

        bool res_a = CanMoveRook(a, b, e, f) && !CanMoveRook(c, d, e, f);
        Console.WriteLine($"а) Белая ладья и черная ладья: **{res_a}**");

        bool res_b = CanMoveRook(a, b, e, f) && !CanMoveQueen(c, d, e, f);
        Console.WriteLine($"б) Белая ладья и черный ферзь: **{res_b}**");

        bool res_v = CanMoveRook(a, b, e, f) && !CanMoveKnight(c, d, e, f);
        Console.WriteLine($"в) Белая ладья и черный конь: **{res_v}**");

        bool res_g = CanMoveRook(a, b, e, f) && !CanMoveBishop(c, d, e, f);
        Console.WriteLine($"г) Белая ладья и черный слон: **{res_g}**");

        bool res_d = CanMoveQueen(a, b, e, f) && !CanMoveQueen(c, d, e, f);
        Console.WriteLine($"д) Белый ферзь и черный ферзь: **{res_d}**");

        bool res_e = CanMoveQueen(a, b, e, f) && !CanMoveRook(c, d, e, f);
        Console.WriteLine($"е) Белый ферзь и черная ладья: **{res_e}**");

         bool res_j = CanMoveQueen(a, b, e, f) && !CanMoveKnight(c, d, e, f);
        Console.WriteLine($"ж) Белый ферзь и черный конь: **{res_j}**");

        bool res_z = CanMoveQueen(a, b, e, f) && !CanMoveBishop(c, d, e, f);
        Console.WriteLine($"з) Белый ферзь и черный слон: **{res_z}**");

        bool res_i = CanMoveKnight(a, b, e, f) && !CanMoveKnight(c, d, e, f);
        Console.WriteLine($"и) Белый конь и черный конь: **{res_i}**");

        bool res_k = CanMoveKnight(a, b, e, f) && !CanMoveRook(c, d, e, f);
        Console.WriteLine($"к) Белый конь и черная ладья: **{res_k}**");

        bool res_l = CanMoveKnight(a, b, e, f) && !CanMoveQueen(c, d, e, f);
        Console.WriteLine($"л) Белый конь и черный ферзь: **{res_l}**");

        bool res_m = CanMoveKnight(a, b, e, f) && !CanMoveBishop(c, d, e, f);
        Console.WriteLine($"м) Белый конь и черный слон: **{res_m}**");

        bool res_n = CanMoveBishop(a, b, e, f) && !CanMoveBishop(c, d, e, f);
        Console.WriteLine($"н) Белый слон и черный слон: **{res_n}**");

        bool res_o = CanMoveBishop(a, b, e, f) && !CanMoveQueen(c, d, e, f);
        Console.WriteLine($"о) Белый слон и черный ферзь: **{res_o}**");

        bool res_p = CanMoveBishop(a, b, e, f) && !CanMoveKnight(c, d, e, f);
        Console.WriteLine($"п) Белый слон и черный конь: **{res_p}**");

        bool res_r = CanMoveBishop(a, b, e, f) && !CanMoveRook(c, d, e, f);
        Console.WriteLine($"р) Белый слон и черная ладья: **{res_r}**");

        bool res_s = CanMoveKing(a, b, e, f) && !CanMoveBishop(c, d, e, f);
        Console.WriteLine($"с) Белый король и черный слон: **{res_s}**");

        bool res_t = CanMoveKing(a, b, e, f) && !CanMoveQueen(c, d, e, f);
        Console.WriteLine($"т) Белый король и черный ферзь: **{res_t}**");

        bool res_u = CanMoveKing(a, b, e, f) && !CanMoveKnight(c, d, e, f);
        Console.WriteLine($"у) Белый король и черный конь: **{res_u}**");

        bool res_f = CanMoveKing(a, b, e, f) && !CanMoveRook(c, d, e, f);
        Console.WriteLine($"ф) Белый король и черная ладья: **{res_f}**");
    }
}