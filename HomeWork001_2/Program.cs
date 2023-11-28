// Найти максимальное из трех чисел
int numA = new Random().Next(1,10);
int numB = new Random().Next(1,10);
int numC = new Random().Next(1,10);
Console.WriteLine(numA);
Console.WriteLine(numB);
Console.WriteLine(numC);
int max = numA;
if (numB > max) 
{
    max = numB;
}
if (numC > max)
{
    max = numC;
}
Console.WriteLine($"Max число = {max}");
