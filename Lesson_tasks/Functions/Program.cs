﻿//                // (a*b)/(c+d) function
// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denumenator = c + d;
//     double result = numenator / denumenator;
//     return result;
// }
// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);
//                       // x^2 function
// void PrintSquares(int limit)
// {
//     int i = 1;
//     while (i <= limit)
//     {
//         Console.Write($"{i * i} ");
//         i++;
//     }
// }
// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);
//          Загадка от Жака Фреско
// void Bar(int a)
// {
//     a = 0;
// }
// int value = 5;
// Bar(value);
// Console.WriteLine(value);

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);