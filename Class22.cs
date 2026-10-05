using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class22
    {
        public static void Ins_Ele()
        {
            Console.WriteLine("Enter Array Size : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Array Element : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Enter Array Element : ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

        }
    }
}