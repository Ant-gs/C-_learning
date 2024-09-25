Console.Write($"Введите число в диапазоне от 10 до 99 включительно: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9 && num < 100)
{
    int second = num%10;
    int first = num/10;
    if (second>first)
    {
        Console.WriteLine($"Максимальная цифра: {second}");
    }
    else
    {
        Console.WriteLine($"Максимальная цифра: {first}");
    }
}
else
{
    Console.WriteLine("Введенное число не входит в диапазон!");
}