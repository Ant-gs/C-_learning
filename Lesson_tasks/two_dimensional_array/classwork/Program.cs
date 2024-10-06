// string GetLettersFromString(string s)
// {
//     int counter = 0;
//     string letters = "";
//     int [] ar = new int [letters.Length];
//     foreach (char e in s)
//     {
//         if (char.IsAsciiDigit(e) == true)
//         {
//             letters = letters + e;
//             ar[counter] = int.Parse(letters);
//             counter = counter + 1;
//         }
//     }
//     return letters;
// }
// string str = Console.ReadLine();
// string result = GetLettersFromString(str);
// Console.WriteLine(result);
// for (int j = 0; j < ar.Length; j++)
// {
//     Console.Write($"{ar[i]} ");
// }
 int counter = 0;
    string let = Console.ReadLine();
    string letters = "";
    string s = "";
    int [] ar = new int [let.Length];
    Console.WriteLine(let.Length);
    foreach (char e in let)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            letters = letters + e;
            s = Char.ToString(e);
            int i = int.Parse(s);
            //Console.WriteLine(i);
            ar[counter] = i;
            counter = counter + 1;
           // Console.Write($"{ar[counter]} ");
        }
    }
    for (int j = 0; j < counter; j++)
    {
        Console.Write($"{ar[j]} ");
    }
    //Console.WriteLine(letters);