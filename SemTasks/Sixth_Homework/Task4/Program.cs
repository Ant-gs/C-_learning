string input = Console.ReadLine();
string ReversePolarity(string str)
{
    string [] splited = str.Split();
    string output = string.Empty;
    for (int i = splited.Length - 1; i > -1; i--)
    {
        output +=splited[i] + " ";
    }
    Console.WriteLine(output);
    return output;
}
string output = ReversePolarity(input);