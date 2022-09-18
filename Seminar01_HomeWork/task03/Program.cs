//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    if (strValue == "") strValue = "0";     // эта строка исключает ошибку
    int value = int.Parse(strValue);
    return (value);
}

int value1 = Prompt("Введите число: ");
if ((value1 % 2) == 0)
{
    System.Console.WriteLine($"{value1} - четное число");
}
else
{
    System.Console.WriteLine($"{value1} - нечетное число");
}