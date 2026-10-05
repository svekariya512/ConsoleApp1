using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class13
    {
        public static void even_odd()
        {
            //Dynamic Array
            int N;
            Console.Write("Enter Array Size : ");
             N = Convert.ToInt32(Console.ReadLine());


            int[] a = new int[N];
            //input element in this aaray
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter Element " + a[i] + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Print array elements
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            int even = 0;
            int odd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("No of Even Elements : " + even);
            Console.WriteLine("No of Odd Elements : " + odd);
        }
    }
}
