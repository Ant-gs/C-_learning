int a = 1;
Console.Write("Hello, enter the number of raws: ");
string? input = Console.ReadLine();
int raw = Convert.ToInt32(input);
Console.Write("Now enter the number of columns: ");
input = Console.ReadLine();
int col = Convert.ToInt32(input);
int [,] table = new int[raw, col];
for (int i = 0; i < raw; i++)
{
    for (int j = 0; j < col; j++)
    {
        //Console.Write("1 ");
        Console.Write($"Enter the {a} number: ");
         string? innput = Console.ReadLine();
         table [i, j] = Convert.ToInt32(innput);
         a = a + 1;
    }
}
for (int i = 0; i < raw; i++)
{
    for (int j = 0; j < col; j++)
    {
         Console.Write($"{table[i,j], 4} ");
    }
    Console.WriteLine();
}