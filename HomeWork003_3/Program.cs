// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
void Reverse()
{
   int [] array = new int[10];
   Random random = new Random();
    for (int i =0; i<array.Length; i++)
    {   array[i] = random.Next(1, 100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for (int i =0; i<array.Length/2; i++)
        {   
            int temporary = array[i];
            array[i] = array[array.Length-1-i];
            array[array.Length-1-i] = temporary;
        }
    for (int i =0; i<array.Length; i++)
    {   
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Reverse();
