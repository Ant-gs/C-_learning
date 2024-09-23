Console.WriteLine();
int[,] CreateRandomMatrix(int rowCount, int colCount)
{
    int[,] matrix = new int[rowCount, colCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1001);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// int[,] table1 = new int[,]
// {
//     {1,1},{2,2},{3,3}
// };
// ShowMatrix(table1);

// int[,] SumOfDigits(int [,] matrixx)
// {
//     int Sum = 0;
//      int[,] matr = new int[rowCount, colCount];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             while (matr[i,j] > 0)
//             Sum = matr[i,j]%10;
//             matr[i,j] = matr[i,j]/10;
//         }
//     }
//     return matr;
// }

int[,] matrix = CreateRandomMatrix(4, 5);
int elements = 0;
// foreach (int e in matrix)
// {
//     if (Isinteresting(e) == true)
//     {
//         Console.Write($"{e} ");
//         elements = elements + 1;
//     }
//     else
//     {
//         Console.Write("- ");
//     elements = elements + 1;
//     }
// }

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (Isinteresting(matrix[i, j]) == true)
        {
            Console.Write($"{matrix[i, j]} ");
            elements = elements + 1;
        }
        else
        {
            Console.Write("--- ");
            elements = elements + 1;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
bool Isinteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
        return true;
    return false;
}
int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return (sum);
}
ShowMatrix(matrix);
Console.
Console.WriteLine();
// string? input= Console.ReadLine();
// int number = Convert.ToInt32(input);
// int Sum = 0;
// while (number > 0)
// {
//     Sum = Sum + number%10; 
//     number = number/10;
//     }
// Console.WriteLine(Sum);                                                                                                                                 