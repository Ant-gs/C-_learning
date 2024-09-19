int[,] CreateMatrix(int rowCount, int colCount)
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
// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);

// int[,] table1 = new int[,]
// {
//     {1,1},{2,2},{3,3}
// };
// ShowMatrix(table1);
int SumOfDigits(int[,] matrix)
{
    Sum = 0;
     int[,] matrix = new int[rowCount, colCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < digitcount; k)
            Sum = matrix[i,j]/10;
        }
    }
    return matrix;
}

bool IsEven()                                                                                                                                   