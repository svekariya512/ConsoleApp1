using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        public static void column()

        {
            for (int i = 1; i <= 4; i++) //no of rows
            {
                //CTRL+K+D
                for (int j = 1; j <= i; j++) // no of column
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

        }
    }
}
