// Вид 1

void Method1 ()
{
    Console.WriteLine ("Автор: Титученко ИЮ");
}

//Method1();

// Вид 2

void Method2 (string msg)
{
    Console.WriteLine (msg);
}

//Method2(msg:"Текст сообщения");

void Method21 (string msg, int count)
{
    for (int i=0;i<count;i++)
    {
        Console.WriteLine (msg);
    }
}
    

//Method21(count:3,msg:"Текст сообщения");

int Method3 ()
{
    return DateTime.Now.Year;
}

int Year=Method3();
//Console.WriteLine (Year);

//Вид 4

string Method4 (int count, string s)
{
    string result=String.Empty;
    for (int i=0;i<count;i++)
    {
        result+=s;
    }
    return result;
}

//Console.WriteLine (Method4 (count:5,s:"a"));
/*
for (int i=2;i<=10;i++)
{
    for (int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

// // // Дан текст. В тексте нужно все пробелы заменить черточками, 
// // // маленькие буквы “к” заменить большими “К”,
// // // a большие “С” заменить маленькими “с”.
// // // Ясна ли задача
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string charReplace (string text, char oldValue, char newValue)
{
    string result=String.Empty;
    for (int i=0;i<text.Length;i++)
    {
        if (text[i]==oldValue) result+=newValue;
        else result+=text[i];
    }
    return result;
}

text= charReplace (text,' ', '_');
text= charReplace (text,'к', 'К');
text= charReplace (text,'С', 'с');

Console.WriteLine (text);
*/

int findMin (int[] arr,int start)
{
    int minIndex=start;
    for (int i=start+1;i<arr.Length;i++)
    {
        if (arr[i]<arr[minIndex]) minIndex=i;
    }
    return minIndex;
}

int findMax (int[] arr,int start)
{
    int maxIndex=start;
    for (int i=start+1;i<arr.Length;i++)
    {
        if (arr[i]>arr[maxIndex]) maxIndex=i;
    }
    return maxIndex;
}


int[] sortArray (int[] arr,bool min)
{
    for (int i=0;i<(arr.Length-1);i++)
    {
        int index=0;
        if (min==true) index=findMin (arr,i);
        else index=findMax (arr,i);
        
        if (index!=i) {
            int temp=arr[i];
            arr[i]=arr[index];
            arr[index]=temp;
        }
    }
    return arr;

}
// Сортировка одномерного массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
PrintArray(sortArray(arr,true));
PrintArray(sortArray(arr,false));
