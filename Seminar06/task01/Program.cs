// Перевернуть одномерный массив
// 

int[] num = { 1, 2, 3, 4, 5 };
int[] num2 = new int[5];

for (int i = 0; i < num.Length; i++)
{
    num2[i] = num[num.Length - 1 - i];
    //Console.Write(num2i);
}
PrintArray(num2);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine();