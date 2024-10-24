        // int sum = 1;
        // void FindFactorial(int number)
        // {
        //     if (number > 0)
        //     {
        //     sum = sum * number;
        //     FindFactorial(number - 1);
        //     }
        //     else
        //     {
        //     Console.WriteLine($"Factorial of this number is: {sum}");
        //     }
        // }
        // Console.Write("Enter your number: ");
        // int input = Convert.ToInt32(Console.ReadLine());
        // FindFactorial (input);
        // int factorial = 1;
        // int Factorial (int n)
        // {
        //     if (n == 1 || n == 0)
        //     {
        //         Console.WriteLine($"Stop requrson, n = {n}");
        //         return 1;
        //     }
        //     Console.WriteLine($"n = {n}");
        //     Factorial(n - 1);
        //     factorial = factorial * (n);
        //     Console.WriteLine($"Return: n = {n}, Factorial = {factorial}");
        //     return factorial;
        // }
        // int input = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(Factorial(input));
            int Fact(int n)
            {
                if (n == 1)
                {
                    Console.WriteLine($"Stop reqursion:n={n}");
                    return 1;
                }
                Console.WriteLine(n);
                int res = n * Fact(n - 1);
                Console.WriteLine($"Возврат:n={n}, fact={res / n}");
                return res;
            }
            Console.Write(Fact(5));