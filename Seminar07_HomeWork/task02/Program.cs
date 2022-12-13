//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите строку элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
{
    Console.WriteLine("Такого элемента нет. Неверные координаты.");
}
else Console.WriteLine(matrix[m - 1, n - 1]);


void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}