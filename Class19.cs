using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class19
    {
        public static void binarysearch()
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

            Array.Sort(a);
            Console.WriteLine("Sorted Array: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Enter the element to search for: ");
            search = Convert.ToInt32(Console.ReadLine());

            int left = 0;
            int right = a.Length - 1;
            bool found = false;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (a[mid] == search)
                {
                    found = true;
                    break;
                }

                else if (a[mid] < search)
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
            }

            if (found)
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
