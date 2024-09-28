Random Rnd = new Random();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int even = 0;
Console.Write($"Случайно заполненный массив: ");
for (int i = 0; i < size; i++)
{
    array[i] = Rnd.Next(100,1000);
    Console.Write($"{array[i]} ");
    if (array[i]%2 == 0)
    {
        even = even + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {even}.");