// int[] arr = {1,41,25,12,17};
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// int n = 10, i = 0;
// int[] arr2 = new int[n];
// while (i < n)
// {
//     arr2[i] = i + 1;
//     Console.WriteLine(arr2[i]);
//     i = i + 1;
// }

int i = 0;
int[] arr = {12, 42, 21, 41, 32, 16, 15, 61, 31, 9};
while (i < arr.Length)
{
    if (arr[i]%2==0)
    {
    Console.WriteLine("Чётый элемент:", arr[i]);
    Console.WriteLine(arr[i]);
    i = i + 1;
    }
    else
    {
        Console.WriteLine("Нечётный элемент: ", arr[i]);
        Console.WriteLine (arr[i]);
        i = i + 1;
    }
}