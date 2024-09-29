int counter = 0;
int[,] CreateTDA(int row,int col)
{
int[,] array = new int [row,col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        counter = counter + 1;
        Console.Write($"Введите {counter} элемент: ");
        int input = Convert.ToInt32(Console.ReadLine());
        array[i,j] = input;
    }
}
return array;
}
void ShowTDA(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j], 4} ");
    }
    Console.WriteLine();
}
}
int[,] arr = CreateTDA(3,4); 
Console.WriteLine();
ShowTDA(arr);
Console.WriteLine();
 for (int i = 0; i < arr.GetLength(0); i+=2)
{
    for (int j = 0; j < arr.GetLength(1); j+=2)
    {
            arr [i,j] = arr [i,j] * arr[i,j];
    }
    Console.WriteLine();
}
ShowTDA(arr);