using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void  digit()

        {
            for(int i = 1; i <= 5; i++) //no of rows
            {
                //CTRL+K+D
                for(int j = 1; j <= 5; j++) // no of column
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}
