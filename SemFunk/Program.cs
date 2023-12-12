// Задача 0;
// Вывести все четные числа в промежутке

// int TestFunk(int first){
//     if (first%2==0){
//     return first;
//     }
//     else {
//         return 0;
//     }
// }
// Console.WriteLine("Enter first number");
// int first_number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number");
// int second_number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// if (first_number>second_number){
//     int temp=first_number;
//     first_number=second_number;
//     second_number=temp;
// }
// while (second_number>=first_number){
//     int res = TestFunk(first_number);
//     if (res!=0){
//         Console.Write($"{res} ");
//     }
//     first_number++;
// }

// Задача1;
// Напишите программу, которая на вход число (А) и выдает сумму чисел от 1 до А.

// void SumNumbers(int A){
//     int sum=0;
//     for (int count=1; count<=A; count++){
//         sum = sum + count;
//     }
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Enter number A");
// int A1 = Convert.ToInt32(Console.ReadLine());
// SumNumbers(A1);

// Задача2:
// На вход принимает число и выдает количество цифр в числе.
// 456 = > 3

// void ost(int num){
//     int count = 1;
//     while (num>10){
//     num = num / 10;
//     count++;
//     }
//     Console.WriteLine(count);
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// ost(num);

// задача3:
// на вход принимает число N, выдает произведение чисел от 1 до N.

// void Prozv(int A){
//     int sum=1;
//     for (int count=1; count<=A; count++){
//         sum = sum * count;
//     }
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Enter number A");
// int A1 = Convert.ToInt32(Console.ReadLine());
// Prozv(A1);

// Задача4
// на вход принимает число N, выдает таблицу квадратов чисел от 1 до N.

void Quard(int A){
    for (int count=1; count<=A; count++){
    Console.Write($"{count*count}, ");
}
}

Console.WriteLine("Enter number A");
int A1 = Convert.ToInt32(Console.ReadLine());
Quard(A1);
