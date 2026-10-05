using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class26
    {
        public static void Delete_Element()
        {
            Console.Write("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter Position to Delete (0 to " + (n - 1) + ") : ");
            int pos = Convert.ToInt32(Console.ReadLine());

            for (int i = pos; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Console.WriteLine("Array After Deletion:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}