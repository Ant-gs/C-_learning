Random rnd = new Random();
string? letter = "";
int br= 0, num = 0, sum =0;
int[] array = new int[];
Console.WriteLine($"Введите ряд целых чисел ({array.Length}), чтобы завершить ввод нажмите q или введите число сумма цифр которого чётная: ");
for (int i = 0; i < array.Length; i++)
{
    letter = Console.ReadLine();
    if (letter == "q")
    {
        br = i;
        break;
    }
    array[i] = Convert.ToInt32(letter);
    for (;array[i] > 0; array[i] = array[i]/10)
    {
    num = array[i] % 10;
    //Console.WriteLine(num);
    sum = sum + num;
    }
    //Console.WriteLine(sum);
    if (sum % 2 == 0)
    {
        br = i;
        break;
    }
    sum = 0;
    // Console.WriteLine(array[i]);

}
for (int i = 0; i < array.Length; i++)
{
    if (i == br)
    {
        break;
    }
    else
    {
    //Console.Write($"{element} ");
    }
}
// using System;
// class Program
// {
// static void Main()
// {
// while (true) // Бесконечный цикл
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine(); // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) // Проверка, является ли ввод числом{
// {
// int sum = 0;
// while (number > 0) // Вычисление суммы цифр числа
// {
// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из числа
// }
// if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
// {
// Console.WriteLine("[STOP]");
// break;
// }
// }
// else // Если ввод не является числом и не 'q', повторить запрос
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
// }
// }
// }
// }