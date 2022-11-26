// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число и степень: ");
int num = Convert.ToInt32(Console.ReadLine());
int degree = Convert.ToInt32(Console.ReadLine());

if (degree != 0)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * num;
    }
    Console.WriteLine(result);
}
else Console.WriteLine("1");