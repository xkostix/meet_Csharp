//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();  // ?? "0" - don't work with empty string
    if (strValue == "") strValue = "0";
    int value = int.Parse(strValue);
    return (value);
}

int value = Prompt("Введите число: ");

int start;
for (start = -value; start <= value; start++)
{
    Console.Write($"{start}, ");
}
