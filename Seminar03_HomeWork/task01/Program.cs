// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindrom(int num1)
{
    int[] array = new int[5];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = num1 % 10;
        num1 = num1 / 10;
        //Console.Write(array[i] + " ");  //For testing
    }
    if (array[0] == array[4] && array[1] == array[3])
    {
        return "Да, это палиндром!";
    }
    else return "Нет, это не палиндром.";
}

Console.Write("Введите 5-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num <= 99999)
{
    Console.WriteLine(Palindrom(num));
}
else
{
    Console.WriteLine("Это не 5-значное число.");
}