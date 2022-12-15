// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 2;
int columns = 2;
int depth = 2;
int[,,] matrix = new int[rows, columns, depth];

FillMatrix3dUniq(matrix);
PrintMatrix3d(matrix);
Console.WriteLine();


void FillMatrix3dUniq(int[,,] matr)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                bool unique = false;
                while (!unique)
                {
                    matr[i, j, k] = new Random().Next(11, 100);
                    if (count > 0)
                    {
                        unique = ifElementUnique(matr[i, j, k], matr, count);
                    }
                    else unique = true;
                }
                count++;
            }
        }
    }
}

void PrintMatrix3d(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                Console.Write($"{matr[i, j, k]}({i}{j}{k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool ifElementUnique(int value, int[,,] matrToCheck, int countToStop)  //if Unique - return true
{
    int countNew = 0;
    for (int l = 0; l < matrToCheck.GetLength(0); l++)
    {
        for (int m = 0; m < matrToCheck.GetLength(1); m++)
        {
            for (int n = 0; n < matrToCheck.GetLength(2); n++)
            {
                if (countNew < countToStop)  //checking only previous positions
                {
                    if (value == matrToCheck[l, m, n]) return false;  //if not Unique - return false
                }
                else return true;  //if Unique - return true
                countNew++;
            }
        }
    }
    return true;   //if come to end of cycle, if Unique - return true
}