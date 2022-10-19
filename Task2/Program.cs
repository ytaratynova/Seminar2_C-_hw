// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a == b*b | b == a*a)
{
    Console.WriteLine("Одно чиcло является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно чило не является квадратом другого");
}