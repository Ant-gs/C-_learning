Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     if (num1%num2 == 0)
//     {
//         Console.WriteLine($"{num1} кратно {num2}.");
//     }
//     else
//     {
//             Console.WriteLine($"{num1} не кратно {num2}, остаток от деления = {num1%num2}");
//     }
int i = 1;
int result = 0;
while (num1>0 || num1<0)
{
if ((num1 > 99 && num1 < 1000) || (num1 > -1000 && num1 < -99))
{
    result = num1 % 10;
    if (num1 < 0)
    {
        Console.WriteLine(result*-1);
    }
    else
    {
    Console.WriteLine(result);
    }
}
 num1 = num1 /10;
 }
 if (result == 0)
 {
    Console.WriteLine("3 цифры нет.");
 }
