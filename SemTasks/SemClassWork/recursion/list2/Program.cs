Console.WriteLine("Введите строку: ");
string? input = Console.ReadLine();
void GetConsonants(string str, int counter = 0)
{
    if (counter == str.Length)
    {
        return;
    }
    string vowels = "aeuioy";
    if (!vowels.Contains(str[counter]))
    {
        Console.Write($"{str[counter]} ");
    }
    GetConsonants(str, counter + 1);
}
GetConsonants(input);