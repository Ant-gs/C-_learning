﻿Random rnd = new Random();
Console.Write("row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("col: ");
int col = Convert.ToInt32(Console.ReadLine());
int [] sum = new int [row];
int [,] array = new int [row,col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        array[i,j] = rnd.Next(0,10);
        Console.Write($"{array[i,j]} ");
        sum[i] = array[i,j] + sum[i];
    }
    Console.WriteLine();
}
for (int i = 0; i < col; i++)
{
    Console.WriteLine($"Sum in row {i} = {sum[i]}");
}