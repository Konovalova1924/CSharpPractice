void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection [index] = new Random().Next(1, 10);
        index = index + 1;
    }
} 

void PrintArra(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position = position + 1;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index<count)
    {
        if (collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array1 = new int [10];
FillArray(array1);
PrintArra(array1);

Console.WriteLine();
int pos = IndexOf(array1, 4);
Console.WriteLine(pos);