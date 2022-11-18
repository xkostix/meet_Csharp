// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
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