using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class11
    {
        public static void sum_Array()
        {
            /*
             For Dynamic 
            Console.Write("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
              */


            int[] a = new int[5];
            //input five element in this aaray
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter No : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Print array elements
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            //Find and print sum and average of all Elements
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum = " + sum);
            float avg = sum/5;
            Console.WriteLine("Average = " + avg);
            //Find and print min and max of all Elements
            int min = a[0];
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }

                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);
        }
    }
}

//a[2][3]
//2 rows and 3 columns
//541
//789
//a[2][2][3]
//represent it logically