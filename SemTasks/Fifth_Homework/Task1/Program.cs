Random rnd = new Random();
Console.Write("row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("col: ");
int col = Convert.ToInt32(Console.ReadLine());
int [] max = new int [row];
int [,] array = new int [row,col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        array[i,j] = rnd.Next(0,10);
        Console.Write($"{array[i,j]} ");
        if (array[i,j] > max[i])
        {
            max[i] = array[i,j];
        }
    }
    Console.WriteLine();
}
for (int i = 0; i < col; i++)
{
    Console.WriteLine($"Max element in row {i} = {max[i]}");
}