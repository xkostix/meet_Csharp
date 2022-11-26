// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// = корень((x2-x1) + (y2-y1) + (z2-z1))

Console.Write("Точка А. Введите x1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Точка А. Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Точка A. Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Точка B. Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Точка B. Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Точка B. Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));
Console.WriteLine();