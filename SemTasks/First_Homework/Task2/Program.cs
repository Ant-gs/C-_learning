using System;
public class Answer {
static int FindMedian(int a, int b, int c)
{
// Введите свое решение ниже
int median;
Console.Write($"Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите 3 число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
{
    median = num1;
}
else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num2 < num1))
{
    median = num2;
}
else
{
    median = num3;
}
Console.WriteLine($"Среднее из введенных чисел: {median}");
}
static public void Main(string[] args) {
int a, b, c;
if (args.Length >= 3) {
a = int.Parse(args[0]);
b = int.Parse(args[1]);
c = int.Parse(args[2]);
} else {
a = 5;
b = 3;
c = 8;
}
int result = FindMedian(a, b, c);
System.Console.WriteLine($"{result}");
}
}
