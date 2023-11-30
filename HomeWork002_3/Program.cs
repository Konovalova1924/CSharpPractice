// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
int numA = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99: {numA}");
int num1 = numA / 10;
int num2 = numA % 10;
if (num1 > num2)
{
    Console.WriteLine($"Большее {num1}");
}
else
{
    Console.WriteLine($"Большее {num2}");
}
