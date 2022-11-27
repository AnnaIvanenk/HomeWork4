int num = 452;
int sum = 0;

while (num > 9)
{
    int first = num % 10;
    num = num / 10;
    sum += first;
};

sum += num;

Console.WriteLine(sum);
