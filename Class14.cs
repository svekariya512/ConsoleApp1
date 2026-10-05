using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class14
    {
        public static void Positive_Negative()
        {
            //Dynamic Array
            Console.Write("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());


            int[] a = new int[n];
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
            int positive = 0;
            int negative = 0;
            int zero = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    positive++;
                }
                else if (a[i] < 0)
                {
                    negative++;
                }

                else
                {
                    zero++;
                }
            }
            Console.WriteLine("No of Positive Elements : " + positive);
            Console.WriteLine("No of Negative Elements : " + negative);
            Console.WriteLine("No of zero Elements : " + zero);
        }
    }
}
