int[] array = new int [10];
double sum = 0;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = rnd.Next(2, 6);
            Console.Write($"{array[i]} ");
            sum = sum + array[i];
    }
    Console.WriteLine();
double avg = sum/array.Length;
Console.WriteLine($"Среднее арифметическое = {avg}");