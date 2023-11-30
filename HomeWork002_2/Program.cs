// Определение координатной плоскости

Console.Write("Введите координаты точки Х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки У:");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine($"Координатная четверть №1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine($"Координатная четверть №2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine($"Координатная четверть №3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine($"Координатная четверть №4");
}
