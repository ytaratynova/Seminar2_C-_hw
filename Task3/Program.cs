// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();

Console.Write("Задайте номер четверти от 1 до 4: ");
int chetvert = int.Parse(Console.ReadLine() ?? "0");

if (chetvert > 0 && chetvert < 5) 
{
    if (chetvert == 1) Console.WriteLine("Координаты по оси X (0, +N), координаты по оси Y (0, +N)");
    if (chetvert == 2) Console.WriteLine("Координаты по оси X (0, -N), координаты по оси Y (0, +N)");
    if (chetvert == 3) Console.WriteLine("Координаты по оси X (0, -N), координаты по оси Y (0, -N)");
    if (chetvert == 4) Console.WriteLine("Координаты по оси X (0, +N), координаты по оси Y (0, -N)");
}
else
{
    Console.WriteLine("Номер четверти введен некорректно");
}