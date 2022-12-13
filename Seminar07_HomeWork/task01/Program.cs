//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] matrix = new double[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();


void FillMatrix(double[,] matr)
{
    double randomNumber;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            randomNumber = Convert.ToDouble(new Random().Next(1, 10)) / Convert.ToDouble(new Random().Next(1, 10));
            matr[i, j] = Math.Round(randomNumber, 2);
        }
    }
}

void PrintMatrix(double[,] matr)
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