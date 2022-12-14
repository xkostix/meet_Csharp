// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[4, 4];
int[] summs = new int[matrix.GetLength(0)];  //хранит муммы элементов по строкам matrix'a

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summs[i] += matrix[i, j];
    }
}

int min = summs[0];
int strNumber = 1;

for (int i = 1; i < summs.Length; i++)  //ищем наименьшее знач в summ
{
    if (summs[i] < min)
    {
        min = summs[i];
        strNumber = i + 1;
    }
}

Console.WriteLine($"Строка {strNumber}");


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

