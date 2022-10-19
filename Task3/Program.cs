// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();

Console.Write("Введите координату Х точки: ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите координату Y точки: ");
int y = int.Parse(Console.ReadLine() ?? "0");

if (x == 0 | y == 0) 
{
    // Если точка находится на одной из осей координат или на пересечении осей координат при (0,0):
    Console.WriteLine("Точка находится на оси координат");
    return;
}

if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("Точка находится в первой четверти");
    }
    else
    {   
        Console.WriteLine("Точка находится в четвертой четверти");
    }
}

if (x < 0)
{
    if (y > 0)
    {
        Console.WriteLine("Точка находится во второй четверти");
    }
    else
    {   
        Console.WriteLine("Точка находится в третьей четверти");
    }
}