using System;
public class Answer {
static void CheckDivisibility(int firstNumber, int secondNumber)
{
// Введите свое решение ниже
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1%num2 == 0)
{
    Console.WriteLine("Делится");
}
else
{
    Console.WriteLine("Не делится");
}
}
static public void Main(string[] args) {
int firstNumber, secondNumber;
if (args.Length >= 2) {
firstNumber = int.Parse(args[0]);
secondNumber = int.Parse(args[1]);
} else {
firstNumber = 10;
secondNumber = 2;
}
CheckDivisibility(firstNumber, secondNumber);
}
}
