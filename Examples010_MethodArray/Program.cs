int[] array = {1,25,3,4,5482,654,8,8,98};

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
    // index = index + 1;
    index++;
}