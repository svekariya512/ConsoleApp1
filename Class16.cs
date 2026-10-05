using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class16
    {
        public static void _2nd_Smallest_Ele()
        {
            Console.Write("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter No : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find Second Smallest Element

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = a[i];
                }
                else if (a[i] < secondSmallest && a[i] != smallest)
                {
                    secondSmallest = a[i];
                }
            }

            Console.WriteLine("Second Smallest Element is : " + secondSmallest);
        }
    }
}