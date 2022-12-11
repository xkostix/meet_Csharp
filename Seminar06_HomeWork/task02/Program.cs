// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение, найдем X: x = (b2 - b1) / (k1 - k2)

Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)   // будет деление на 0 при нахождении X
{
    Console.WriteLine("Прямые параллельны или совпадают.");
}
else
{

    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"x = {x}; y = {y}");
}




//   Пример решения:
//   AB  x - 3y + 4 = 0        
//   CD  x + 2y - 16 = 0
//   x = 3y - 4  =>  x = 3(-0.5x + 8) - 4
//   y = -0.5x + 8 =>  y = -0.5(3y - 4) + 8  

// Пример решения:
// a1x = -b1y - c1 => x = (-b1y - c1) / a1 =>
// b2y = -a2x - c2 => y = (-a2x - c2) / b2 =>

// x = ( -b1( (-a2x - c2) / b2) - c1 ) / a1 =>
// y = ( -a2( (-b1y - c1) / a1) - c2) / b2 =>

// x = ( (b1a2x + b1c2) / b2 - c1 ) / a1 =>
// y = ( (a2b1y + a2c1) / a1 - c2) / b2  =>

// x = ( (b1a2x + b1c2 - b2c1) / b2 ) / a1 =>
// y = ( (a2b1y + a2c1 - a1c2)  / a1) / b2 =>

// x = ( b1a2x + b1c2 - b2c1)  /  b2 a1 =>
// y = ( a2b1y + a2c1 - a1c2)  / a1 b2 =>

// xb2a1 - b1a2x = b1c2 - b2c1 =>
// ya1b2 - a2b1y = a2c1 - a1c2  =>

// x = (b1c2 - b2c1) / (b2a1 - b1a2)
// y = (a1c1 - a1c2) / (a1b2 - a1b1)