char[,] chars = new char[,] {{ 'a', 'b', 'c', 'd', 'e' },{'f', 'g', 'h', 'i', 'j'}};
string str = string.Empty;
for (int i = 0; i < chars.GetLength(0); i++)
{
    for (int j = 0; j < chars.GetLength(1); j++)
    {
        str += chars[i,j];
    }
}
Console.WriteLine(str);