Console.WriteLine("Введите нижнюю границу: ");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу: ");
int input2 = Convert.ToInt32(Console.ReadLine());
void ShowAllNumbersBetween(int a, int b)
{
    if (a > b)
    {
      Console.Write($"{a} ");
      if (a < b)
      {
      return;
      }
      ShowAllNumbersBetween(a - 1, b);
    }
    else if (a < b)
    {
      Console.Write($"{a} ");
      if (a > b)
      {
      return;
      }
      ShowAllNumbersBetween(a + 1, b);
    }
    else
    {
        Console.WriteLine(a);
    }
}
Console.Write($"Числа в диапазоне от {input1} до {input2}: ");
ShowAllNumbersBetween(input1, input2);