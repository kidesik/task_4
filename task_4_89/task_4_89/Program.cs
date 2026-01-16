Console.WriteLine("Введите час прибытия поезда ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минуты прибытия поезда ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите час отправления поезда ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минуты отправления поезда ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите час прихода пассажира ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минуты прихода пассажира ");
int m = Convert.ToInt32(Console.ReadLine());

int arrivalTime = a * 60 + b;
int departureTime = c * 60 + d;
int passengerTime = n * 60 + m;

bool isTrainPresent; 
if (arrivalTime <= departureTime)
{
    isTrainPresent = (passengerTime >= arrivalTime && passengerTime <= departureTime);
}
else
{
    isTrainPresent = (passengerTime >= arrivalTime || passengerTime <= departureTime);
}

if (isTrainPresent)
{
    Console.WriteLine("Поезд будет стоять на платформе.");
}
else
{
    Console.WriteLine("Поезда не будет на платформе.");
}