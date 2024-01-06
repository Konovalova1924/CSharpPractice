// Задача1: 
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива
// string GetStringFromCharArray(char[,] array)
// {
// string res = "";
// foreach (char elem in array)
// {
// res += elem;
// }
// return res;
// }

// char[,] myArray = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'g', 'h', 'i' } };
// string str = GetStringFromCharArray(myArray);
// Console.WriteLine(str);

// Задача 2:
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string FilterString(string str)
// {
// string res = str.ToLower();
// string count = "";
// foreach (char elem in res)
// {
// if (elem != ' ')
// {
// count += elem;
// }
// }
// return count;
// }
// string str = "The J u S t Do It";
// string res = FilterString(str);
// Console.WriteLine(res);

// Задача 3:
// Задайте произвольную строку. Выясните, является ли она палиндромом.

// string FilterString(string str)
// {
// string res = str.ToLower();
// string count = "";
// foreach (char elem in res)
// {
// if (elem != ' ')
// {
// count += elem;
// }
// }
// return count;
// }

// string IsPalindrome(string str)
// {
// for (int i = 0; i < str.Length / 2; i++)
// {
// if (str[i] != str[str.Length - i - 1])
// {
// return "String is not palindrome";
// }
// }
// return "String is palindrome";
// }
// 
// string str = "Wow";
// string res = FilterString(str);
// Console.WriteLine(IsPalindrome(res));
