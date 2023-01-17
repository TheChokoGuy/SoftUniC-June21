using System;

namespace SumAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isFound = false;
            for(int n1 = 1; n1 < 9; n1++)
            {
                for (int n2 = 9; n2 >= n1; n2--)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 9; n4 >= n3; n4--)
                        {
                                double check1 = (n1 * n2 * n3 * n4) / (n1 + n2 + n3 + n4);
                                if (n1 + n2 + n3 + n4 == n1 * n2 * n3 * n4 && n % 10 == 5)
                                {
                                    Console.WriteLine($"{n1}{n2}{n3}{n4}");
                                    isFound = true;
                                    break;
                                }
                                else if (check1 >= 3 && check1 < 4 && n % 3 == 0)
                                {
                                    Console.WriteLine($"{n4}{n3}{n2}{n1}");
                                    isFound = true;
                                    break;
                                }
                        }
                        if(isFound)
                        {
                            break;
                        }
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            if(isFound == false)
            {
                Console.WriteLine($"Nothing found");
            }
            
        }
    }
}
