// Напишите программу вычисления модуля числа.
//2 -> 2
//-3 -> 3

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return (value);
}

int value = Prompt("Введите число: ");

if (value < 0)
{
    System.Console.WriteLine(-value);
}
else
{
    System.Console.WriteLine(value);
}