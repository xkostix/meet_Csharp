// Принимает 3 числа и проверяет, может ли быть треугольник с длиной сторон.
// Сторона Треугольника меньше сумм двух других сторон

Console.Write("Введите сторону AB: ");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону BC: ");
int s2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону AC: ");
int s3 = Convert.ToInt32(Console.ReadLine());

if (s1 < (s2 + s3) && s2 < (s1 + s3) && s3 < (s1 + s2)) Console.WriteLine("Да, треугольник");
else Console.WriteLine("Не треугольник.");