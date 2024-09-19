//Random
// Random rnd = new Random();
// int size = 100;
// int[] arr_int = new int[size];
// int i = 0;
// while (i < size)
// {
//     arr_int[i] = rnd.Next(1, 10);
//     i = i + 1;
// }
// i = 0;
// while (i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i = i + 1;
// }
//Enter
int size = 5;
int i = 0;
int[] arr_integ = new int[size];
while (i < size)
{
    Console.Write($"Enter {i + 1} element of array: ");
string input = Console.ReadLine();
arr_integ[i] = Convert.ToInt32(input);
    i = i + 1;
}
i = 0;
while (i < size)
{
    Console.Write($"{arr_integ[i]} ");
    i = i + 1;
}