// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Strings = 3;   //чтобы менять значение в коде
int Columns = 4;   //чтобы менять значение в коде
int[,] matrix = new int[Strings, Columns];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int sum;
double[] average = new double[Columns];
double avg;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    avg = Convert.ToDouble(sum) / Convert.ToDouble(matrix.GetLength(0));
    average[j] = Math.Round(avg, 2);
}

PrintArrayOfDouble(average);
Console.WriteLine();
// The end.


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


void PrintArrayOfDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}