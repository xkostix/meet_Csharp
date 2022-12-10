// Задача 38: Задайте массив вещественных ? чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = { 2.5, 1.6, 4.6, 3.55, 4 };
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

double difference = Math.Round(max - min, 2);

PrintArray(array);
Console.WriteLine($"Мин {min}, Макс {max}");
Console.WriteLine($"Разность {difference}");
Console.WriteLine();


void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine("]");
}