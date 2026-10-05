using System;

namespace ConsoleApp1
{
    internal class Class23
    {
        public static void Copy_Array()
        {
            Console.Write("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];

            // Input
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }

            Console.WriteLine("Copied Array :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
    }
}