//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";  //Вернул ??, чтобы компилятор не ругался
    if (strValue == "") strValue = "0";
    int value = int.Parse(strValue);
    return (value);
}

int value1 = Prompt("Введите первое число: ");
int value2 = Prompt("Введите второе число: ");
int value3 = Prompt("Введите третье число: ");
int max = value1;
if (max < value2) max = value2;
if (max < value3) max = value3;
System.Console.WriteLine($"Максимальное из чисел: {max}");