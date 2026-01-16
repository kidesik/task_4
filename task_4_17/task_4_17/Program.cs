Console.WriteLine("Hello, World!");
DateTime today = DateTime.Now;
int currentYear = today.Year;
int currentMonth = today.Month;
int year_birth = Convert.ToInt32(Console.ReadLine());
int moth_birth = Convert.ToInt32(Console.ReadLine());
int age = currentYear - year_birth;
if (moth_birth > currentMonth) {
    age -= 1;
    Console.WriteLine("Ваш возраст " + age + " лет");
}
else if (moth_birth < currentYear)
{
    Console.WriteLine("Ваш возраст " + age + " лет");
}