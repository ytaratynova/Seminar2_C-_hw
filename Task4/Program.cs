// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
int[] firstdot = new int[3];
int[] seconddot = new int[3];
string[] xyz = new string[3] {"X", "Y", "Z"};
int index = 0;
int sum = 0;

void EnterData(int[] array) // Метод для ввода координат точек
{
    int index = 0;
    while (index < 3)
    {
        Console.Write($"координата {xyz[index]}: ");
        array[index] = int.Parse(Console.ReadLine() ?? "0");
        index++;
    }
}
Console.WriteLine("Введите координату первой точки:"); // Вводим координаты первой и второй точки,
EnterData(firstdot);                                   // если точки на плоскости, то Z координата
Console.WriteLine("Введите координату второй точки:"); //будет равна "0"
EnterData(seconddot);

while (index < 3)
{
 sum = sum + (seconddot[index] - firstdot[index]) * (seconddot[index] - firstdot[index]);
 index++;
}

Console.WriteLine("Расстояние между точками:");
Console.WriteLine(Math.Sqrt(sum));
