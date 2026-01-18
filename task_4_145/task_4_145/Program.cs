Console.Write("Введите год нашей эры (например, 2024): ");
int g = Convert.ToInt32(Console.ReadLine());

int offset = g - 1984;

int animalIndex = (offset % 12 + 12) % 12;

int colorIndex = (offset % 10 + 10) % 10 / 2;

string animalName;
string colorName;
switch (animalIndex)
{
    case 0: animalName = "Крыса"; break;
    case 1: animalName = "Корова"; break;
    case 2: animalName = "Тигр"; break;
    case 3: animalName = "Заяц"; break;
    case 4: animalName = "Дракон"; break;
    case 5: animalName = "Змея"; break;
    case 6: animalName = "Лошадь"; break;
    case 7: animalName = "Овца"; break;
    case 8: animalName = "Обезьяна"; break;
    case 9: animalName = "Петух"; break;
    case 10: animalName = "Собака"; break;
    case 11: animalName = "Свинья"; break;
    default: animalName = "Неизвестное животное"; break; 
}
switch (colorIndex)
{
    case 0: colorName = "Зеленый"; break;
    case 1: colorName = "Красный"; break;
    case 2: colorName = "Желтый"; break;
    case 3: colorName = "Белый"; break;
    case 4: colorName = "Черный"; break;
    default: colorName = "Неизвестный цвет"; break; 
}
Console.WriteLine($"Название года: {colorName} {animalName}");