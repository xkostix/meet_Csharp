// X+ Y+ = 1   x+ y- = 4
// -x -y = 3  -x +y = 2

Console.Write("Введите Х ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Числа не должны быть равны нулю");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else
{
    Console.WriteLine("2 четверть");
}