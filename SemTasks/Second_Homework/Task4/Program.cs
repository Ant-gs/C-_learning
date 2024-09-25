Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for (;num > 0;num = num/10)
{
    int digit = num%10;
       if (num > 10)
    {
    Console.Write($"{digit}, ");
    }
    else
    {
        Console.Write(num);
    }
}
