// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Пусть даны две прямоугольные матрицы A и B l×m и m×n соответственно,
// Тогда матрица С размерностью l × n :
// Элемент C[i,j] = сумма произв a[i,r]*b[r,j]  где i = 1..l; j = 1..n; r = 1..m

int l = 2;
int m = 2;
int n = 2;

int[,] matrA = new int[l, m];
int[,] matrB = new int[m, n];
int[,] matrC = new int[l, n];

FillMatrix(matrA);
FillMatrix(matrB);
PrintMatrix(matrA);
Console.WriteLine();
PrintMatrix(matrB);
Console.WriteLine();

for (int i = 0; i < l; i++)
{
    for (int j = 0; j < n; j++)  //Includes finding element value of matrC
    {
        for (int r = 0; r < m; r++)  //Summing multiplications
        {
            matrC[i, j] += matrA[i, r] * matrB[r, j];  // One multiplication  /it's my comments, I'm training English too :) /
        }
    }
}

PrintMatrix(matrC);
//The end.


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