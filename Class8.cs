using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class8
    {
        public static void pyramid()
        {
            int rows = 4;
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
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
