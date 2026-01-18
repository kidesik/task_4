Console.Write("Введите возраст Мити: ");
int ageMitya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите возраст Васи: ");
int ageVasya = Convert.ToInt32(Console.ReadLine());
string comparison = (ageMitya > ageVasya) ? "Митя старше" : ((ageVasya > ageMitya) ? "Вася старше" : "Они одного возраста");
Console.WriteLine(comparison);