using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Find the Second Largest Elememt 
namespace ConsoleApp1
{
    internal class Class15
    {
        public static void _2nd_Largest_Element()
        {
            Console.Write("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter No : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Find the Second Largest Element
            int largest = a[0];
            int secondLargest = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    secondLargest = largest;
                    largest = a[i];
                }
                else if (a[i] > secondLargest && a[i] != largest)
                {
                    secondLargest = a[i];
                }
            }
            Console.WriteLine("Second Largest Element is : " + secondLargest);
        }
    }
}