using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class18
    {
        public static void linearsearch()
        {
            int n, search;
            int count = 0;

            Console.Write("Enter Array Size : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter No : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Enter the element to search for: ");
            search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == search)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("The element " + search + " is found in the array.");
            }

            else
            {
                Console.WriteLine("The element " + search + " is not found in the array.");
            }
        }
    }
}
