// Задача1: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// int SumOfDigits(int num){
//     if(num == 0) return 0;
//     int res = num % 10 + SumOfDigits(num/10);
//     return res;
// }

// int result = SumOfDigits(125);
// Console.WriteLine(result);


// Задача2: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

// void NaturNum(int n){
//     if (n > 0) {
//         NaturNum(n-1);
//         Console.Write(n + " ");
//     }
//     else if(n<0){
//         Console.WriteLine("Numb must be graiter then 0");
//     }    
// }

// NaturNum(5);

// Задача3: Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d 

// void ShowConsonants(string s){
//     if (s.Length == 0) return;
//     string upper = "bcdfghjklmnpqrstvwxz";
//     if(upper.Contains(char.ToLower(s[0]))){
//         Console.Write(s[0]+" ");
//     }
//     ShowConsonants(s.Substring(1));
// }

// ShowConsonants("Hello world!");