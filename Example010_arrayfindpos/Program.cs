// Найти элемент массива, равный find

int [] array = {1, 3, 5, 8, 4, 6, 8, 1};
int n = array.Length;
int find = 8;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index +1;
}
