// Проверка на четность
int num1 = new Random().Next(1, 10);

if (num1 % 2 == 0)
{
    Console.WriteLine($"Число `{num1}` четное");
}
if (num1 % 2 == 1)
{
    Console.WriteLine($"Число `{num1}` нечетное");
}