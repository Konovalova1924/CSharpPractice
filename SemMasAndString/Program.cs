// Задача1: Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 

//Указание
//Конструктор строки вида string(char []) не использовать.

// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// метод GetStringFromCharArray загоняет символы в массив

// string GetStringFromCharArray(char [] chars){
//     string res = "";
//     foreach (char elem in chars){
//         res += elem;
//     }
//     return res;
// }

// char [] chars = {'a','d','c','b'};
// string str = GetStringFromCharArray(chars);
// Console.WriteLine(str);


//Задача2 : На основе символов строки (тип string) сформировать 
//массив символов (тип char[]). Вывести массив на экран.

//Указание
//Метод строки ToCharArray() не использовать.
// формирование символьного массива
// char [] StringToCharArray(string str){
//     char [] chars = new char [str.Length];
//     for (int i=0; i<str.Length; i++){
//         chars[i] = str[i];
//     }
//     return chars;
// }
// вывод символьного массива на экран:
// void ShowCharsArr(char [] chars)
// {
//     foreach(char elem in chars){
//         Console.Write(elem+" ");
//     }
// }
// string str = "Hello";
// char [] chars = StringToCharArray(str);
// ShowCharArr(chars);


// Задача3: Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
//Выяснить, сколько среди введённых букв гласных.

//Пример
//“hello” => 2
//“world” => 1

// int GetCountVovelsInString(string str){
// string vovels = 'aeiou';
// int count = 0;
// foreach(char elem in str){
//     foreach(char vol in vovels){
//         if(vol == elem){
//             count++;
//         }
//     }
// }
// return count;
// }
// string str = "Hello";
//int chars = GetCountVovelsInString(str);
//Console.WriteLine($"Vovels in {str} is {chars}");


// Задача4: Даны строки S и S0. 
// Найти количество входжений строки S0 в строку S.

// int GetCountVovelsInString(string str, string str1){
// int count = 0;
// foreach(char elem in str){
//     foreach(char vol in str1){
//         if(vol == elem){
//             count++;
//         }
//     }
// }
// return count;
// }
// string str = "Hello";
// string str1 = "Hello world!";
//int chars = GetCountVovelsInString(str, str1);
//Console.WriteLine($" Count of includes in {str} from {str1} is {chars}");


//Задача5: Определите, является ли исходная строка символов палиндромом
//(читается одинаково с начала и с конца). 
//Регистры символов и пробелы игнорируйте.

string FilterString(string str){
    string res = str.ToLower();
    string count = "";
    foreach(char elem in res){
        if(elem != ' '){
            count+=elem;
        }
    }
    return count;
}

string IsPalindrome(string str){
    for(int i = 0; i<str.Length/2; i++){
        if(str[i] != str[str.Length-i-1]){
            return("String is not palindrome");
        }
    }
    return("String is palindrome");
}

string str = "ROT     toR";
string res = FilterString(str);
Console.WriteLine(IsPalindrome(res));