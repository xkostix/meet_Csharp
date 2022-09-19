//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    if (strValue == "") strValue = "0";     // эта строка исключает ошибку
    int value = int.Parse(strValue);
    return (value);
}

int value1 = Prompt("Введите число: ");
if (value1 < 2)
{
    System.Console.WriteLine("Число должно быть не меньше 2.");
}
else
{
    for (int i = 2; i <= value1; i = i + 2)
    {
        System.Console.Write($"{i}; ");
    }
}