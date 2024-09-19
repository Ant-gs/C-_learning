void Get1Info()
{
    Console.Write("Введите нижнюю границу диапазона: ");
    string? input= Console.ReadLine();
    int firstnum = Convert.ToInt32(input);
    Console.WriteLine();
    Console.Write("Введите верхнюю границу диапазона: ");
    input= Console.ReadLine();
    int secondnum = Convert.ToInt32(input);
    int counter = 0;
    while (firstnum <= secondnum)
    {
        int digitnum = firstnum;
        while (digitnum > 0)
        {
            int digit = digitnum%10;
            if (digit == 1)
            {
                counter = counter + 1;
            }
            digitnum = digitnum/10;
            //Console.WriteLine($"{digit} dig");
        }
        firstnum = firstnum + 1;
    }
        Console.WriteLine($"Count of 1 is: {counter}");
}

Get1Info();