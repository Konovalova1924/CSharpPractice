// На вход принимает трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

int num = 851;
int first = num / 100;
int second = num % 10;
int result = first*10 + second;
Console.WriteLine (result);
Console.WriteLine ($"{first}\t{second}");

