using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class9
    {
        public static void No()
        {
            int rows = 4;
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces

                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" " +number+ " ");
                    number++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
