int[] array = { 23, 12, 14, 16, 98, 124, 124, 235, 63 };

int n = array.Length;
int find = 124;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

