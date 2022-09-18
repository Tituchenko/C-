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
int indexOf (int[] collection, int find)
{
    int length=collection.Length;
    int index=0;
    int position=-1;
    while (index<length)
    {
        if (collection[index]==find)
        {
            position=index;
            break;
            
        }
        index++;
    }
    return position;
}
int[] array = new int [10];
fillArray(array);
printArray (array);

int whatFind=4;
int findedIndex=indexOf (array,whatFind);
if (findedIndex!=-1) Console.WriteLine ($"Элемент {whatFind} в массиве есть под индексом {findedIndex}");