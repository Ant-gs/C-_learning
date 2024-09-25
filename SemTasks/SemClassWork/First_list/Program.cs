using System;
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ( num > 99 && num < 1000)
{
int Second = num / 10 % 10;
int Third = num % 10;
int result = Second;
Console.WriteLine(Second);
Console.WriteLine(Third);
for (int i = 1; i < Third; i++)
{
    Console.WriteLine($"{Second} в {i} степени = {result}");
    result = result * Second;
}
 Console.WriteLine($"{Second} в {Third} степени = {result}");
//Console.WriteLine(num);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным!");
}