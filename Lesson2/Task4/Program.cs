using System.Globalization;

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
Console.WriteLine(max);

int max1 = arr[0];
for(int j = 0; j < arr.Length; j++)
{
    if(arr[j] > max)
    {
        max1 = arr[j];
    }
}
Console.WriteLine(max1);

max = arr[0];
foreach(int e in arr)
{
    if(e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);



