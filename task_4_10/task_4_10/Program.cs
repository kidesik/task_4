Console.WriteLine("введите два растояния в футах и в киллометрах");
double ft = Convert.ToInt32(Console.ReadLine()) * 0.3048;
int km  = Convert.ToInt32(Console.ReadLine()) * 1000;
if (ft < km) {
    Console.WriteLine("Растоянение в киллометрах больше чем в футах");
}
else if (ft > km)
{
    Console.WriteLine("Растоянение в футах больше чем в киллометрах");
}
else
{
    Console.WriteLine("расстояния равны");
}