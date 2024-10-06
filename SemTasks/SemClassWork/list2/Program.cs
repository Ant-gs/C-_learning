Console.WriteLine("Введите строку: ");
int counter = 0;
string str = Console.ReadLine();
string vowels = "eyuioa";
for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < vowels.Length; j++)
    {
        if (str[i] == vowels[j])
        {
            counter = counter + 1;
        }
    }
}
Console.WriteLine($"В введённой строке {counter} гласных букв.");