using System;

namespace ConsoleApp1
{
    internal class Class6
    {
        public static void Main()
        {
            int k = 1;

            for (int i = 1; i <= 5; i++) // Row
            {
                if (i % 2 == 0) // Even row
                {
                    int temp = k + i - 1;

                    for (int j = 1; j <= i; j++) // Column
                    {
                        Console.Write(temp + " ");
                        temp--;
                    }

                    k = k + i;
                }
                else // Odd row
                {
                    for (int j = 1; j <= i; j++) // Column
                    {
                        Console.Write(k + " ");
                        k++;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}