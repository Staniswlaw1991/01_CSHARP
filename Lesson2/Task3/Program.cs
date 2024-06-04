int[] arr = { 1, 5, 4, 6, 9, 3, 2, 5, 4, 1 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    //i = i + 1;
    i++;
}

