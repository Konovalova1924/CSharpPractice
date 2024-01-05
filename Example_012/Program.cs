// string [,] table = new string [2,5];
// table[1,2] = "слово";
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4] 
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]
// String.Empty

// for (int row =0; row<2; row++){
//     for (int col=0; col<5; col++){
//         Console.WriteLine($" --{table[row, col]}-- ");
//     }
// }

void PrintArray(int [,] matrix) // вывод массива на печать
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
{
    for ( int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j] }");
    }
    Console.WriteLine();
}
}

void FillArray (int [,] matrix) // заполнение массива 
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
{
    for ( int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10); // числа будут от 1 до 9
    }
}
}

int [,] matr = new int [3,4];
PrintArray(matr);
FillArray(matr);
Console.WriteLine();
PrintArray(matr);