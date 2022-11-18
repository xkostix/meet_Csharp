// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Уточнение: сделано без массивов, словарей, строк.

Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());

int len = 1;
int i = value / 10;
while (Math.Abs(i) > 0)
{
    // Console.Write($"{i}, "); //For test
    len++;
    i = i / 10;
}

// Console.WriteLine($"  length = {len}"); //for test

if (len < 3) Console.WriteLine("Третьей цифры нет.");
else
{
    int v3 = value;
    for (int k = 1; k <= (len - 3); k++)
    {
        v3 = v3 / 10;
    }
    Console.WriteLine($"Третья цифра: {Math.Abs(v3 % 10)}");
}