//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return (value);
}

int value1 = Prompt("Введите число a: ");
int value2 = Prompt("Введите число b: ");

if (value1 == value2)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    if (value1 > value2)
    {
        System.Console.WriteLine($"Число {value1} больше, чем {value2}");
    }
    else
    {
        System.Console.WriteLine($"Число {value2} больше, чем {value1}");
    }
}
