// На вход принимает трехзначное число и возводит вторую цифру этого числа в степень, 
// равную третьей цифре.
// 487 -> 8^7 =  2 097 152
// 254 -> 5^4 = 625
// 617 -> 1

int num = 617;
int first = (num % 100) / 10;
int second = num % 10;
int count = 1; 
int result = first;
while (count < second)
{
    result = result*first;
    count = count + 1;
}
Console.WriteLine ($"{first}^{second} = {result}");

