// Вывести четные числа интересным способом
int number = new Random().Next(1, 10);
int maxcount = 0;
int i = 2;
if (number % 2 == 0)
{
    maxcount = number;
} 
if (number %2 == 1)
{
    maxcount = number - 1;
}
Console.Write($"number = {number} ->    {i}");

while (i < maxcount)
{
    i = i + 2;
    Console.Write($"    {i}");
}

