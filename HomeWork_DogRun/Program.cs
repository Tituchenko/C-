int count=0, friend=2;
double distance=10000,
        firstFriendSpeed=1, secondFriendSpeed=2,
        dogSpeed=5,
        time=0;
while (distance>10)
{
    if (friend==1)
    {
        time=distance/(secondFriendSpeed+dogSpeed);
        friend=2;
    }
    else
    {
        time=distance/(firstFriendSpeed+dogSpeed);
        friend=1;
    }
    distance+=-(firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}

Console.Write ("Собака пробежит ");
Console.WriteLine (count);