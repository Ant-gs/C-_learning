Random rnd = new Random();
int sum = 0;
Console.Write("rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("colmns: ");
int  col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [row,col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)   
    {
        array [i,j] = rnd.Next(0,10);
        Console.Write($"{array[i,j], 4} ");
        if (i == j)
        {
            sum = sum + array[i,j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма = {sum}");