int count = 0;
int distance = 10;
int first_speed =1;
int second_speed = 2;
int dog_speed = 5;
int friend = 2;
int time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (first_speed + dog_speed);
        friend = 2;
    }
    else
    {
        time = distance / (second_speed + dog_speed);
        friend =1;
    }

    distance = distance - (first_speed + second_speed) * time;
    count += 1;
}

Console.WriteLine(distance);
