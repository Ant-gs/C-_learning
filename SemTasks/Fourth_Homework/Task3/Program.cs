Random Rnd = new Random();
Console.Write("Введите длину массива: ");
int changer = 0;
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.Write($"Случайно заполненный массив: ");
for (int i = 0; i < size; i++)
{
    array[i] = Rnd.Next(100,1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.Write($"Заменённый массив: ");
for (int i = 0; i < size/2; i++)
{
    changer = array[i];
    array[i] = array[size-i-1];
    array[size - i - 1] = changer;
}
for (int i = 0; i < size; i++)
{
     Console.Write($"{array[i]} ");
}