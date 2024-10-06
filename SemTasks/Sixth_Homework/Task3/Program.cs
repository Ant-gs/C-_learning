Console.Write("Введите строку: ");
string input = Console.ReadLine();
int counter = 0, l = 0;
for (int i = 0; i < input.Length/2; i++)
{
    //Console.WriteLine(input.Length - i);
    l = input.Length;
    //Console.WriteLine(input[l - i - 1]);
    if (input[i] == input[l - i - 1])
    {
        //Console.WriteLine($"Symbol {i} is same");
        counter = counter + 1;
    }
}
if (counter == l/2)
{
    Console.WriteLine("Полиндром!");
}
//Console.WriteLine(input);
// {
// string input = "КУЦЦУК";
// bool isPalindrome = IsPalindrome(input);
// Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// bool IsPalindrome(string str)
// {
// string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
