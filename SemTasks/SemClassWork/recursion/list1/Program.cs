Console.WriteLine("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
int GetSumOfDigits(int num)
{
    if (num <= 0)
    {
        return 0;
    }
    int del = num % 10;
    return del + GetSumOfDigits(num/10);
}
Console.WriteLine(GetSumOfDigits(input));