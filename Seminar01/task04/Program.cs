// Факториал от N

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return (value);
}

int value = Prompt("Введите число: ");

int i;
int result = 1;
for (i = 1; i <= value; i++)
{
    result = result * i;
}

System.Console.WriteLine($"Факториал от {value} = {result}");