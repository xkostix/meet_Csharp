// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через Enter, в конце введите пустую строку:");

string str;
int num;
int count = 0;

while (true)
{
    str = Console.ReadLine();
    if (str.Trim() == "") break;
    num = Convert.ToInt32(str);
    if (num > 0) count++;
}

Console.WriteLine($"Чисел больше нуля: {count}");