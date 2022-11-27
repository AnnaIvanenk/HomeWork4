
// int[] CreateArray(int count)
//   {
//     return new int[count];
//   }

// CreateArray(8);

  string PrintGood(int[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[";

    while (i < size)
    {
      result += ($"{numbers[i],3} ");
      i++;
    }
    return result + "]";
  }

int[] array = {1, 2, 5, 7, 19};
Console.WriteLine (PrintGood(array));

int[] array2 = {6, 1, 33};
Console.WriteLine (PrintGood(array2));