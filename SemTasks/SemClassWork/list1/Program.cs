// Console.Write("Введите строку: ");
// string symbol = Console.ReadLine();
// Console.WriteLine(symbol.Length);
// string letter = "";
// char[] chars = new char[symbol.Length];
// for (int i = 0; i < symbol.Length; i++)
// {
//     Console.Write($"{symbol[i]} ");
// }

char[] chars = new char[] { 'a', 'b', 'c', 'd', 'e' };
string str = string.Empty;
foreach (char e in chars)
{
    str = str + e;
}
Console.WriteLine(str);
