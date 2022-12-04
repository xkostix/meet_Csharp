// Преобразовывает десятичное в двоичное число
// 45 > 101101
// 3 > 11
// 2 > 10

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Binary(num));


string Binary(int num10)
{
    int ost = num10 % 2;
    num10 = num10 / 2;
    if (num10 == 1) return "1" + Convert.ToString(ost);
    else return Binary(num10) + Convert.ToString(ost);
}