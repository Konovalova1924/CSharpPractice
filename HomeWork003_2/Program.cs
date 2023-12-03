// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void EvenQyantity()
{
   int [] array = new int[10];
   Random random = new Random();
    int count2 = 0;
    for (int i =0; i<array.Length; i++)
    {   array[i] = random.Next(100, 1000);
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0)
        {   count2 = count2 + 1;
        }
    }
Console.WriteLine();
Console.WriteLine($"кол-во четных чисел в массиве: {count2}");
}

EvenQyantity();

