int[] array = { 14, 2, 7, 35, 43, 45, 36, 7, 18, 9 };

int n = array.Length;
int find = 7;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}