Console.WriteLine("Введите длину массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int [l];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
            array[i] = rnd.Next(-10, 11);
            Console.Write($"{array[i]} ");
    }
Console.WriteLine();
Console.WriteLine("Удаляем отрицательные элементы...");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    { 
        Console.Write($"{array[i]} ");
    }
}