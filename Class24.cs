using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class24
    {public static void Main (string[] args)

        {
            int n, position;
         

            Console.WriteLine("enter size array:");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a= new int[n];

            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write("Enter No : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array:");


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            
             position = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)

                {
                    Console.Write(a[i]);

                }

                else
                {
                    Console.WriteLine(a[i]);
                }
            }
            

        }
    }
}
