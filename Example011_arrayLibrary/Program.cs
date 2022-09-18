void fillArray (int[] collection)
{
    int length=collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void printArray (int[] col)
{
    int cont=col.Length;
    int ind=0;
    Console.Write ("(");
    while (ind<cont)
    {
        Console.Write ($"[{ind}]->{col[ind]}");
        ind++;
        if (ind!=cont) Console.Write (",");
    }
    Console.WriteLine (")");
}

int[] array = new int [10];
fillArray(array);
printArray (array);