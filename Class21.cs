using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class21
    {
        public static void last_occurence()
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

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == search)
                {
                    count++;
                    Console.WriteLine("The last occurrence of the element " + search + " is at index " + i);
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("The element " + search + " is not found in the array.");
            }
        }   


    }
}
