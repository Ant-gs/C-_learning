Random rnd = new Random();
double sum = 0;
Console.Write("rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("colmns: ");
int  col = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[row];
int[,] array = new int [row,col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)   
    {
        array [i,j] = rnd.Next(0,10);
        Console.Write($"{array[i,j], 4} ");
        sum = array[i,j] + sum;
    }
    arr[i] = sum/col;
    Console.WriteLine();
    sum = 0;
}
for (int i = 0; i < row; i++)
{
    Console.Write($"{arr[i]}   ");
}