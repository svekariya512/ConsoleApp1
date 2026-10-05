using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        public static void  row()
        {
            int k = 1;
            for (int i = 1; i <= 5; i++) //no of rows
            {
                //CTRL+K+D
                for (int j = 1; j <= i; j++) // no of column
                {
                    
                    Console.Write(k + " ");
                    k = k + 2;


                }
                k = 1;
                Console.WriteLine();
            }
        }
}
}
