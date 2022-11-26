// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = num % 10;
while (num != 0)
{
    sum = sum + i;
    num = num / 10;
    i = num % 10;
}

Console.WriteLine(sum);