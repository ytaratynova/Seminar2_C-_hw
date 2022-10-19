﻿// Дано число обозначающее день недели. Выяснить является номер дня недели выходным(
Console.Clear();
string[] weekdays = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Введите число, соответствующее дню недели: " ?? "0");
int day = int.Parse(Console.ReadLine());

if (day > 0 && day < 8) // Проверка корректности введенных данных
{
    if (day - 1 < 5)
    {
        Console.Write($"{weekdays[day-1]} - будний день, идите работать! ");
    }
    else
    {
        Console.Write($"{weekdays[day-1]} - выходной день, нужно отдохнуть :)");
    }
}
else
{
    Console.WriteLine("Данное число не соответсвует ни одному из дней недели");
}