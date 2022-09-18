int Max (int arg1,int arg2,int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}
int a1=11;
int b1=67;
int c1=87;
int a2=21;
int b2=56;
int c2=68;
int a3=34;
int b3=89;
int c3=76;

int max1=Max(a1,b1,c1);
int max2=Max(a2,b2,c2);
int max3=Max(a3,b3,c3);

int finalMax=Max(max1,max2,max3);

Console.WriteLine ($"Максимальное число {finalMax}");