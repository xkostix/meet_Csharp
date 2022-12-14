// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

BubbleSort(matrix);
PrintMatrix(matrix);


void BubbleSort(int[,] matr)    //пузырьковая сортировка
{
    int steps = matr.GetLength(1) - 1;
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)  //проход по всем строкам
    {
        for (int leftToSort = steps; leftToSort > 0; leftToSort--)  //проход по элементам одной строки
        {
            int min = matr[i, 0];
            for (int j = 0; j < leftToSort; j++)  //замена 2-х соседних элементов
            {
                if (matr[i, j] < matr[i, j + 1])
                {
                    temp = matr[i, j + 1];
                    matr[i, j + 1] = matr[i, j];
                    matr[i, j] = temp;
                }
            }
        }
    }
}

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