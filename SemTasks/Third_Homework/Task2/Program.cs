Console.WriteLine();
int[] array = new int [10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = rnd.Next(-10, 11);
            Console.Write($"{array[i]} ");
    }
Console.WriteLine();
Console.WriteLine("Замена...");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0 || array[i] > 0)
    {
        array[i] = array[i] * -1;
    }
      Console.Write($"{array[i]} ");
}