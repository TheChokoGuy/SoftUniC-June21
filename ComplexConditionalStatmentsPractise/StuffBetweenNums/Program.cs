using System;

namespace StuffBetweenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double result = 0.0;
            string operation = Console.ReadLine();

            if (num1 != 0 && num2 != 0)
            {
                if (operation == "/")
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
            }
            else
            {
                if(operation == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                }
            }

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    if(result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {result} - odd");
                    }
                    break;
                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {result} - odd");
                    }
                    break;
                case "*":
                    result = num1 * num2;
                    if(result % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {result} - odd");
                    }
                    break;
                case "%":
                    result = num1 % num2;
                    if(num1 != 0 && num2 != 0)
                    {
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
            }

        }
    }
}
