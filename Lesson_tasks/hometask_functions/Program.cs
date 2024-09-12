int n = 10;
int[] arr = new int[n];
int i = 0, sum = 0, product = 1;
void FillArray(int[] array)
{
    while (i < n)
    {
        arr[i] = i + 1;
        //i = i + 1;
        //Console.WriteLine(arr[i]);
        i = i + 1;
    }
    i = 0;
}
void PrintArray(int[] array)
{
    while (i < n)
    {
        Console.WriteLine(arr[i]);
        i = i + 1;
    }
    i = 0;
}
int GetSumOfElements(int[] array)
{
    while (i < n)
    {

        sum = arr[i] + sum;
        i = i + 1;
    }
    i = 0;
    return sum;
}
int GetProductOfElements(int[] array)
{
    while (i < n)
    {

        product = arr[i] * product;
        i = i + 1;
    }
    i = 0;
    return product;
}
FillArray(arr);
PrintArray(arr);
int s = GetSumOfElements(arr);
int p = GetProductOfElements(arr);
Console.WriteLine(s);
Console.WriteLine(p);
