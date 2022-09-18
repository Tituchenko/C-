int[] array={16,62,35,4,51,62,57,48,95};
int n=array.Length;

int find=62;

int index=0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}