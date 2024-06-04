int[] arr = { 77, 4, 5, 44, 2, 7, 9 };
int i = 0;
int max = arr[i];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
Console.Write(max);


