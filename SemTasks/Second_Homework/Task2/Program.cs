﻿Console.Write($"Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if ((x>0 || x <0) && (y > 0 || y <0 ))
{
    if (x>0 && y>0)
    {
        Console.WriteLine("1");
    }
    else if (x >0 && y < 0)
    {
        Console.WriteLine("2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    else 
    {
        Console.WriteLine("4");
    }
}
else
{
    Console.WriteLine("Ошибка, в введенных значениях обнаружен 0!");
}