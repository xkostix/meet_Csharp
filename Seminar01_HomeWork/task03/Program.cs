// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int value1 = Convert.ToInt32(Console.ReadLine());

if ((value1 % 2) == 0)
{
    System.Console.WriteLine($"{value1} - четное число");
}
else
{
    System.Console.WriteLine($"{value1} - НЕчетное число");
}