using System;
class Answer {
static void CheckNumber(int number)
{
// Введите свое решение ниже
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("Введенное число является положительным.");
}
else if (num < 0)
{
    Console.WriteLine("Введенное число является отрицательным.");
}
else
{
Console.WriteLine("Введенное число является нулем.");
}
}
static public void Main(string[] args) {
int number;
if (args.Length >= 1) {
number = int.Parse(args[0]);
} else {
number = 7;
}
CheckNumber(number);
}
}
