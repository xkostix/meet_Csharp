// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= a; i++)
// {
//     sum = sum + i;
// }

// Console.WriteLine(sum);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int Factorial(int n)
{
    int prod = 1;
    for (int i = 2; i <= n; i++)
    {
        prod = prod * i;
    }
    return prod;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Factorial(a));