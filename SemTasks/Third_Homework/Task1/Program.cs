Console.Write("Введите длину массива: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите проверяемое число: ");
int f = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
bool check = false;
for (int i = 0; i < l; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
array [i] = Convert.ToInt32(Console.ReadLine());
if (array[i] == f)
{
    check = true;
}
}
if (check == false)
{
Console.WriteLine("Ваше число не было найдено.");
}
else
{
    Console.WriteLine($"Число присутствует");
}