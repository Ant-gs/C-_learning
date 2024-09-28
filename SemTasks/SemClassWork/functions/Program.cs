Random rnd = new Random();
int counter = 0, counter1 = 0;
int[] CreateArrayRnd (int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min,max);
        Console.Write($"{array[i]} ");
        if (array[i] == 0)
        {
            counter = counter + 1;
        }
        else
        {
            counter1 = counter1 + 1;
        }
    }
    return array;
}

int[] b = CreateArrayRnd(100000,0,2);
Console.WriteLine(" ");
Console.WriteLine(counter);
Console.WriteLine(counter1);
