// Random rnd = new Random();
// int[] array = new int [rnd.Next(5,11)];
// int l = array.Length;
// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = rnd.Next(1,6);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// Console.WriteLine(l);
// for (int i = 0; i < l/2; i ++)
// {
//     array [i] = array [i] * array[l-1-i];
//     Console.Write($"{array[i]} ");
// }
Random rnd = new Random();
int number = rnd.Next(100,1000);
Console.WriteLine(number);
int[] array = new int [3];
int l = array.Length;
for (int i = 0; i < array.Length; i++)
{
    array [i] = number%10;
    number = number/10;
}
for (int i = 0; i < array.Length; i++)
{
;
    Console.Write($"{array[l-1-i]} ");
}