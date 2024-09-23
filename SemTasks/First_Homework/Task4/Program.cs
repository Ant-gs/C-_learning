Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Ошибка. Введенное число не является положительным!");
}
Console.WriteLine("Ряд нечётных числа от 1 до вашего числа(включительно):");
for (int i = 1; i <= num; i = i + 2)
{
    Console.Write($"{i} ");
}