// int number = 3;
// int degree = 5;

int RaisingToDegree (int num, int deg)
{
    int result = num * num;

    while (deg > 2)
    {
    result *= num;
    deg --;
    }
return result;
    // Console.WriteLine(result);
}

Console.WriteLine(RaisingToDegree(2, 4));





// int number2 = 2;
// int degree2 = 4;

// int result2 = number2 * number2;

// while (degree2 > 2)
// {
//     result2 = result2 * number2;
//     degree2 --;
// }
// Console.WriteLine(result2);