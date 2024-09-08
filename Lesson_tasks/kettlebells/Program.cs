// int a = 5, b = 67, c = 5, d = 62, e = 14;
// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// if (d > max)
// {
//     max = d;
// }
// if (e > max)
// {
//     max = e;
// }
// Console.WriteLine(max);

// int i = 0;
//int[] arr = { 2, 5, 12, 6, 77 };
// int max = arr[i];
// while (i < arr.Length)
// {
//     if (arr[i] > max)
//    {
//         max = arr[i];
//     }
//     i = i + 1;
// }
// Console.WriteLine(max);

// int[] arr = { 2, 5, 12, 6, 77 };
// int max = arr[0];
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > max)
//    {
//         max = arr[i];
//    }
// }
// Console.WriteLine(max);

int[] arr = { 2, 5, 12, 6, 77 };
int max = arr[0];
foreach (int i in arr)
{
    if (i > max)
    {
        max = i;
    }
}
Console.WriteLine(max);