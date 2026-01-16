Console.WriteLine("Введите три значнения роста");
int height_a = Convert.ToInt32(Console.ReadLine());
int height_b = Convert.ToInt32(Console.ReadLine());
int height_c = Convert.ToInt32(Console.ReadLine());
if  (height_a == height_b && height_a == height_c && height_c == height_b)
{
    Console.WriteLine("рост одинаков");
}
else
{
    Console.WriteLine("рост отличается");
}